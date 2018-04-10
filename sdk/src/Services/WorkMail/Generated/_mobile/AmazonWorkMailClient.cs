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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.WorkMail.Model;
using Amazon.WorkMail.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.WorkMail
{
    /// <summary>
    /// Implementation for accessing WorkMail
    ///
    /// Amazon WorkMail is a secure, managed business email and calendaring service with support
    /// for existing desktop and mobile email clients. You can access your email, contacts,
    /// and calendars using Microsoft Outlook, your browser, or their native iOS and Android
    /// email applications. You can integrate Amazon WorkMail with your existing corporate
    /// directory and control both the keys that encrypt your data and the location in which
    /// your data is stored.
    /// 
    ///  
    /// <para>
    /// The Amazon WorkMail API is designed for the following scenarios:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Listing and describing organizations
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    /// Managing users
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    /// Managing groups
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    /// Managing resources
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// All Amazon WorkMail API actions are Amazon-authenticated and certificate-signed. They
    /// not only require the use of the AWS SDK, but also allow for the exclusive use of IAM
    /// users and roles to help facilitate access, trust, and permission policies. By creating
    /// a role and allowing an IAM user to access the Amazon WorkMail site, the IAM user gains
    /// full administrative visibility into the entire Amazon WorkMail organization (or as
    /// set in the IAM policy). This includes, but is not limited to, the ability to create,
    /// update, and delete users, groups, and resources. This allows developers to perform
    /// the scenarios listed above, as well as give users the ability to grant access on a
    /// selective basis using the IAM model.
    /// </para>
    /// </summary>
    public partial class AmazonWorkMailClient : AmazonServiceClient, IAmazonWorkMail
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonWorkMailClient with the credentials loaded from the application's
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
        public AmazonWorkMailClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkMailConfig()) { }

        /// <summary>
        /// Constructs AmazonWorkMailClient with the credentials loaded from the application's
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
        public AmazonWorkMailClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkMailConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonWorkMailClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonWorkMailClient Configuration Object</param>
        public AmazonWorkMailClient(AmazonWorkMailConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonWorkMailClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonWorkMailClient(AWSCredentials credentials)
            : this(credentials, new AmazonWorkMailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkMailClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonWorkMailConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailClient with AWS Credentials and an
        /// AmazonWorkMailClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonWorkMailClient Configuration Object</param>
        public AmazonWorkMailClient(AWSCredentials credentials, AmazonWorkMailConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonWorkMailClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkMailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkMailClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkMailConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkMailClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonWorkMailClient Configuration Object</param>
        public AmazonWorkMailClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonWorkMailConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonWorkMailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkMailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkMailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkMailConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkMailClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonWorkMailClient Configuration Object</param>
        public AmazonWorkMailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonWorkMailConfig clientConfig)
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

        
        #region  AssociateDelegateToResource

        internal virtual AssociateDelegateToResourceResponse AssociateDelegateToResource(AssociateDelegateToResourceRequest request)
        {
            var marshaller = AssociateDelegateToResourceRequestMarshaller.Instance;
            var unmarshaller = AssociateDelegateToResourceResponseUnmarshaller.Instance;

            return Invoke<AssociateDelegateToResourceRequest,AssociateDelegateToResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDelegateToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDelegateToResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateDelegateToResource">REST API Reference for AssociateDelegateToResource Operation</seealso>
        public virtual Task<AssociateDelegateToResourceResponse> AssociateDelegateToResourceAsync(AssociateDelegateToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateDelegateToResourceRequestMarshaller.Instance;
            var unmarshaller = AssociateDelegateToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateDelegateToResourceRequest,AssociateDelegateToResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateMemberToGroup

        internal virtual AssociateMemberToGroupResponse AssociateMemberToGroup(AssociateMemberToGroupRequest request)
        {
            var marshaller = AssociateMemberToGroupRequestMarshaller.Instance;
            var unmarshaller = AssociateMemberToGroupResponseUnmarshaller.Instance;

            return Invoke<AssociateMemberToGroupRequest,AssociateMemberToGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateMemberToGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateMemberToGroup">REST API Reference for AssociateMemberToGroup Operation</seealso>
        public virtual Task<AssociateMemberToGroupResponse> AssociateMemberToGroupAsync(AssociateMemberToGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateMemberToGroupRequestMarshaller.Instance;
            var unmarshaller = AssociateMemberToGroupResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateMemberToGroupRequest,AssociateMemberToGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAlias

        internal virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var marshaller = CreateAliasRequestMarshaller.Instance;
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasRequest,CreateAliasResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateAliasRequestMarshaller.Instance;
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAliasRequest,CreateAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateGroup

        internal virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var marshaller = CreateGroupRequestMarshaller.Instance;
            var unmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupRequest,CreateGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateGroupRequestMarshaller.Instance;
            var unmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupRequest,CreateGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateResource

        internal virtual CreateResourceResponse CreateResource(CreateResourceRequest request)
        {
            var marshaller = CreateResourceRequestMarshaller.Instance;
            var unmarshaller = CreateResourceResponseUnmarshaller.Instance;

            return Invoke<CreateResourceRequest,CreateResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateResource">REST API Reference for CreateResource Operation</seealso>
        public virtual Task<CreateResourceResponse> CreateResourceAsync(CreateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateResourceRequestMarshaller.Instance;
            var unmarshaller = CreateResourceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceRequest,CreateResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateUser

        internal virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var marshaller = CreateUserRequestMarshaller.Instance;
            var unmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserRequest,CreateUserResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateUserRequestMarshaller.Instance;
            var unmarshaller = CreateUserResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserRequest,CreateUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAlias

        internal virtual DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            var marshaller = DeleteAliasRequestMarshaller.Instance;
            var unmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAliasRequest,DeleteAliasResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteAliasRequestMarshaller.Instance;
            var unmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAliasRequest,DeleteAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteGroup

        internal virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var marshaller = DeleteGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupRequest,DeleteGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGroupRequest,DeleteGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteMailboxPermissions

        internal virtual DeleteMailboxPermissionsResponse DeleteMailboxPermissions(DeleteMailboxPermissionsRequest request)
        {
            var marshaller = DeleteMailboxPermissionsRequestMarshaller.Instance;
            var unmarshaller = DeleteMailboxPermissionsResponseUnmarshaller.Instance;

            return Invoke<DeleteMailboxPermissionsRequest,DeleteMailboxPermissionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMailboxPermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteMailboxPermissions">REST API Reference for DeleteMailboxPermissions Operation</seealso>
        public virtual Task<DeleteMailboxPermissionsResponse> DeleteMailboxPermissionsAsync(DeleteMailboxPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteMailboxPermissionsRequestMarshaller.Instance;
            var unmarshaller = DeleteMailboxPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMailboxPermissionsRequest,DeleteMailboxPermissionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteResource

        internal virtual DeleteResourceResponse DeleteResource(DeleteResourceRequest request)
        {
            var marshaller = DeleteResourceRequestMarshaller.Instance;
            var unmarshaller = DeleteResourceResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceRequest,DeleteResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        public virtual Task<DeleteResourceResponse> DeleteResourceAsync(DeleteResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteResourceRequestMarshaller.Instance;
            var unmarshaller = DeleteResourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourceRequest,DeleteResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteUser

        internal virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var marshaller = DeleteUserRequestMarshaller.Instance;
            var unmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserRequest,DeleteUserResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteUserRequestMarshaller.Instance;
            var unmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserRequest,DeleteUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterFromWorkMail

        internal virtual DeregisterFromWorkMailResponse DeregisterFromWorkMail(DeregisterFromWorkMailRequest request)
        {
            var marshaller = DeregisterFromWorkMailRequestMarshaller.Instance;
            var unmarshaller = DeregisterFromWorkMailResponseUnmarshaller.Instance;

            return Invoke<DeregisterFromWorkMailRequest,DeregisterFromWorkMailResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterFromWorkMail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterFromWorkMail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeregisterFromWorkMail">REST API Reference for DeregisterFromWorkMail Operation</seealso>
        public virtual Task<DeregisterFromWorkMailResponse> DeregisterFromWorkMailAsync(DeregisterFromWorkMailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeregisterFromWorkMailRequestMarshaller.Instance;
            var unmarshaller = DeregisterFromWorkMailResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterFromWorkMailRequest,DeregisterFromWorkMailResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeGroup

        internal virtual DescribeGroupResponse DescribeGroup(DescribeGroupRequest request)
        {
            var marshaller = DescribeGroupRequestMarshaller.Instance;
            var unmarshaller = DescribeGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeGroupRequest,DescribeGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        public virtual Task<DescribeGroupResponse> DescribeGroupAsync(DescribeGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeGroupRequestMarshaller.Instance;
            var unmarshaller = DescribeGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGroupRequest,DescribeGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrganization

        internal virtual DescribeOrganizationResponse DescribeOrganization(DescribeOrganizationRequest request)
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeOrganization">REST API Reference for DescribeOrganization Operation</seealso>
        public virtual Task<DescribeOrganizationResponse> DescribeOrganizationAsync(DescribeOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeOrganizationRequestMarshaller.Instance;
            var unmarshaller = DescribeOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOrganizationRequest,DescribeOrganizationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeResource

        internal virtual DescribeResourceResponse DescribeResource(DescribeResourceRequest request)
        {
            var marshaller = DescribeResourceRequestMarshaller.Instance;
            var unmarshaller = DescribeResourceResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceRequest,DescribeResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeResource">REST API Reference for DescribeResource Operation</seealso>
        public virtual Task<DescribeResourceResponse> DescribeResourceAsync(DescribeResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeResourceRequestMarshaller.Instance;
            var unmarshaller = DescribeResourceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResourceRequest,DescribeResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeUser

        internal virtual DescribeUserResponse DescribeUser(DescribeUserRequest request)
        {
            var marshaller = DescribeUserRequestMarshaller.Instance;
            var unmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return Invoke<DescribeUserRequest,DescribeUserResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual Task<DescribeUserResponse> DescribeUserAsync(DescribeUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeUserRequestMarshaller.Instance;
            var unmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUserRequest,DescribeUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateDelegateFromResource

        internal virtual DisassociateDelegateFromResourceResponse DisassociateDelegateFromResource(DisassociateDelegateFromResourceRequest request)
        {
            var marshaller = DisassociateDelegateFromResourceRequestMarshaller.Instance;
            var unmarshaller = DisassociateDelegateFromResourceResponseUnmarshaller.Instance;

            return Invoke<DisassociateDelegateFromResourceRequest,DisassociateDelegateFromResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDelegateFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDelegateFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateDelegateFromResource">REST API Reference for DisassociateDelegateFromResource Operation</seealso>
        public virtual Task<DisassociateDelegateFromResourceResponse> DisassociateDelegateFromResourceAsync(DisassociateDelegateFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateDelegateFromResourceRequestMarshaller.Instance;
            var unmarshaller = DisassociateDelegateFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateDelegateFromResourceRequest,DisassociateDelegateFromResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateMemberFromGroup

        internal virtual DisassociateMemberFromGroupResponse DisassociateMemberFromGroup(DisassociateMemberFromGroupRequest request)
        {
            var marshaller = DisassociateMemberFromGroupRequestMarshaller.Instance;
            var unmarshaller = DisassociateMemberFromGroupResponseUnmarshaller.Instance;

            return Invoke<DisassociateMemberFromGroupRequest,DisassociateMemberFromGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMemberFromGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateMemberFromGroup">REST API Reference for DisassociateMemberFromGroup Operation</seealso>
        public virtual Task<DisassociateMemberFromGroupResponse> DisassociateMemberFromGroupAsync(DisassociateMemberFromGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateMemberFromGroupRequestMarshaller.Instance;
            var unmarshaller = DisassociateMemberFromGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateMemberFromGroupRequest,DisassociateMemberFromGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAliases

        internal virtual ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            var marshaller = ListAliasesRequestMarshaller.Instance;
            var unmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAliasesRequest,ListAliasesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListAliasesRequestMarshaller.Instance;
            var unmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAliasesRequest,ListAliasesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGroupMembers

        internal virtual ListGroupMembersResponse ListGroupMembers(ListGroupMembersRequest request)
        {
            var marshaller = ListGroupMembersRequestMarshaller.Instance;
            var unmarshaller = ListGroupMembersResponseUnmarshaller.Instance;

            return Invoke<ListGroupMembersRequest,ListGroupMembersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroupMembers">REST API Reference for ListGroupMembers Operation</seealso>
        public virtual Task<ListGroupMembersResponse> ListGroupMembersAsync(ListGroupMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListGroupMembersRequestMarshaller.Instance;
            var unmarshaller = ListGroupMembersResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupMembersRequest,ListGroupMembersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGroups

        internal virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var marshaller = ListGroupsRequestMarshaller.Instance;
            var unmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsRequest,ListGroupsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListGroupsRequestMarshaller.Instance;
            var unmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupsRequest,ListGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListMailboxPermissions

        internal virtual ListMailboxPermissionsResponse ListMailboxPermissions(ListMailboxPermissionsRequest request)
        {
            var marshaller = ListMailboxPermissionsRequestMarshaller.Instance;
            var unmarshaller = ListMailboxPermissionsResponseUnmarshaller.Instance;

            return Invoke<ListMailboxPermissionsRequest,ListMailboxPermissionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMailboxPermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMailboxPermissions">REST API Reference for ListMailboxPermissions Operation</seealso>
        public virtual Task<ListMailboxPermissionsResponse> ListMailboxPermissionsAsync(ListMailboxPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListMailboxPermissionsRequestMarshaller.Instance;
            var unmarshaller = ListMailboxPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMailboxPermissionsRequest,ListMailboxPermissionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListOrganizations

        internal virtual ListOrganizationsResponse ListOrganizations(ListOrganizationsRequest request)
        {
            var marshaller = ListOrganizationsRequestMarshaller.Instance;
            var unmarshaller = ListOrganizationsResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationsRequest,ListOrganizationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListOrganizations">REST API Reference for ListOrganizations Operation</seealso>
        public virtual Task<ListOrganizationsResponse> ListOrganizationsAsync(ListOrganizationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListOrganizationsRequestMarshaller.Instance;
            var unmarshaller = ListOrganizationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOrganizationsRequest,ListOrganizationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListResourceDelegates

        internal virtual ListResourceDelegatesResponse ListResourceDelegates(ListResourceDelegatesRequest request)
        {
            var marshaller = ListResourceDelegatesRequestMarshaller.Instance;
            var unmarshaller = ListResourceDelegatesResponseUnmarshaller.Instance;

            return Invoke<ListResourceDelegatesRequest,ListResourceDelegatesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceDelegates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDelegates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResourceDelegates">REST API Reference for ListResourceDelegates Operation</seealso>
        public virtual Task<ListResourceDelegatesResponse> ListResourceDelegatesAsync(ListResourceDelegatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListResourceDelegatesRequestMarshaller.Instance;
            var unmarshaller = ListResourceDelegatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceDelegatesRequest,ListResourceDelegatesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListResources

        internal virtual ListResourcesResponse ListResources(ListResourcesRequest request)
        {
            var marshaller = ListResourcesRequestMarshaller.Instance;
            var unmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return Invoke<ListResourcesRequest,ListResourcesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResources">REST API Reference for ListResources Operation</seealso>
        public virtual Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListResourcesRequestMarshaller.Instance;
            var unmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourcesRequest,ListResourcesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListUsers

        internal virtual ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var marshaller = ListUsersRequestMarshaller.Instance;
            var unmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersRequest,ListUsersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListUsersRequestMarshaller.Instance;
            var unmarshaller = ListUsersResponseUnmarshaller.Instance;

            return InvokeAsync<ListUsersRequest,ListUsersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutMailboxPermissions

        internal virtual PutMailboxPermissionsResponse PutMailboxPermissions(PutMailboxPermissionsRequest request)
        {
            var marshaller = PutMailboxPermissionsRequestMarshaller.Instance;
            var unmarshaller = PutMailboxPermissionsResponseUnmarshaller.Instance;

            return Invoke<PutMailboxPermissionsRequest,PutMailboxPermissionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMailboxPermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutMailboxPermissions">REST API Reference for PutMailboxPermissions Operation</seealso>
        public virtual Task<PutMailboxPermissionsResponse> PutMailboxPermissionsAsync(PutMailboxPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutMailboxPermissionsRequestMarshaller.Instance;
            var unmarshaller = PutMailboxPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutMailboxPermissionsRequest,PutMailboxPermissionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterToWorkMail

        internal virtual RegisterToWorkMailResponse RegisterToWorkMail(RegisterToWorkMailRequest request)
        {
            var marshaller = RegisterToWorkMailRequestMarshaller.Instance;
            var unmarshaller = RegisterToWorkMailResponseUnmarshaller.Instance;

            return Invoke<RegisterToWorkMailRequest,RegisterToWorkMailResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterToWorkMail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterToWorkMail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/RegisterToWorkMail">REST API Reference for RegisterToWorkMail Operation</seealso>
        public virtual Task<RegisterToWorkMailResponse> RegisterToWorkMailAsync(RegisterToWorkMailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RegisterToWorkMailRequestMarshaller.Instance;
            var unmarshaller = RegisterToWorkMailResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterToWorkMailRequest,RegisterToWorkMailResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetPassword

        internal virtual ResetPasswordResponse ResetPassword(ResetPasswordRequest request)
        {
            var marshaller = ResetPasswordRequestMarshaller.Instance;
            var unmarshaller = ResetPasswordResponseUnmarshaller.Instance;

            return Invoke<ResetPasswordRequest,ResetPasswordResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResetPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetPassword operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ResetPassword">REST API Reference for ResetPassword Operation</seealso>
        public virtual Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ResetPasswordRequestMarshaller.Instance;
            var unmarshaller = ResetPasswordResponseUnmarshaller.Instance;

            return InvokeAsync<ResetPasswordRequest,ResetPasswordResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdatePrimaryEmailAddress

        internal virtual UpdatePrimaryEmailAddressResponse UpdatePrimaryEmailAddress(UpdatePrimaryEmailAddressRequest request)
        {
            var marshaller = UpdatePrimaryEmailAddressRequestMarshaller.Instance;
            var unmarshaller = UpdatePrimaryEmailAddressResponseUnmarshaller.Instance;

            return Invoke<UpdatePrimaryEmailAddressRequest,UpdatePrimaryEmailAddressResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePrimaryEmailAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrimaryEmailAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdatePrimaryEmailAddress">REST API Reference for UpdatePrimaryEmailAddress Operation</seealso>
        public virtual Task<UpdatePrimaryEmailAddressResponse> UpdatePrimaryEmailAddressAsync(UpdatePrimaryEmailAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdatePrimaryEmailAddressRequestMarshaller.Instance;
            var unmarshaller = UpdatePrimaryEmailAddressResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePrimaryEmailAddressRequest,UpdatePrimaryEmailAddressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateResource

        internal virtual UpdateResourceResponse UpdateResource(UpdateResourceRequest request)
        {
            var marshaller = UpdateResourceRequestMarshaller.Instance;
            var unmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceRequest,UpdateResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        public virtual Task<UpdateResourceResponse> UpdateResourceAsync(UpdateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateResourceRequestMarshaller.Instance;
            var unmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResourceRequest,UpdateResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}