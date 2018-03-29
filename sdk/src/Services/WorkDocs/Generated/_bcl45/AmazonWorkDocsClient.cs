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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.WorkDocs.Model;
using Amazon.WorkDocs.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.WorkDocs
{
    /// <summary>
    /// Implementation for accessing WorkDocs
    ///
    /// The WorkDocs API is designed for the following use cases:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// File Migration: File migration applications are supported for users who want to migrate
    /// their files from an on-premises or off-premises file system or service. Users can
    /// insert files into a user directory structure, as well as allow for basic metadata
    /// changes, such as modifications to the permissions of files.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Security: Support security applications are supported for users who have additional
    /// security needs, such as antivirus or data loss prevention. The API actions, along
    /// with AWS CloudTrail, allow these applications to detect when changes occur in Amazon
    /// WorkDocs. Then, the application can take the necessary actions and replace the target
    /// file. If the target file violates the policy, the application can also choose to email
    /// the user.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// eDiscovery/Analytics: General administrative applications are supported, such as eDiscovery
    /// and analytics. These applications can choose to mimic or record the actions in an
    /// Amazon WorkDocs site, along with AWS CloudTrail, to replicate data for eDiscovery,
    /// backup, or analytical applications.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// All Amazon WorkDocs API actions are Amazon authenticated and certificate-signed. They
    /// not only require the use of the AWS SDK, but also allow for the exclusive use of IAM
    /// users and roles to help facilitate access, trust, and permission policies. By creating
    /// a role and allowing an IAM user to access the Amazon WorkDocs site, the IAM user gains
    /// full administrative visibility into the entire Amazon WorkDocs site (or as set in
    /// the IAM policy). This includes, but is not limited to, the ability to modify file
    /// permissions and upload any file to any user. This allows developers to perform the
    /// three use cases above, as well as give users the ability to grant access on a selective
    /// basis using the IAM model.
    /// </para>
    /// </summary>
    public partial class AmazonWorkDocsClient : AmazonServiceClient, IAmazonWorkDocs
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonWorkDocsClient with the credentials loaded from the application's
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
        public AmazonWorkDocsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkDocsConfig()) { }

        /// <summary>
        /// Constructs AmazonWorkDocsClient with the credentials loaded from the application's
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
        public AmazonWorkDocsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkDocsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonWorkDocsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonWorkDocsClient Configuration Object</param>
        public AmazonWorkDocsClient(AmazonWorkDocsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonWorkDocsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonWorkDocsClient(AWSCredentials credentials)
            : this(credentials, new AmazonWorkDocsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkDocsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkDocsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonWorkDocsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkDocsClient with AWS Credentials and an
        /// AmazonWorkDocsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonWorkDocsClient Configuration Object</param>
        public AmazonWorkDocsClient(AWSCredentials credentials, AmazonWorkDocsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkDocsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonWorkDocsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkDocsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkDocsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkDocsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkDocsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkDocsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkDocsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonWorkDocsClient Configuration Object</param>
        public AmazonWorkDocsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonWorkDocsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkDocsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonWorkDocsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkDocsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkDocsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkDocsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkDocsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkDocsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkDocsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonWorkDocsClient Configuration Object</param>
        public AmazonWorkDocsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonWorkDocsConfig clientConfig)
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

        
        #region  AbortDocumentVersionUpload


        /// <summary>
        /// Aborts the upload of the specified document version that was previously initiated
        /// by <a>InitiateDocumentVersionUpload</a>. The client should make this call only when
        /// it no longer intends to upload the document version, or fails to do so.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AbortDocumentVersionUpload service method.</param>
        /// 
        /// <returns>The response from the AbortDocumentVersionUpload service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/AbortDocumentVersionUpload">REST API Reference for AbortDocumentVersionUpload Operation</seealso>
        public virtual AbortDocumentVersionUploadResponse AbortDocumentVersionUpload(AbortDocumentVersionUploadRequest request)
        {
            var marshaller = AbortDocumentVersionUploadRequestMarshaller.Instance;
            var unmarshaller = AbortDocumentVersionUploadResponseUnmarshaller.Instance;

            return Invoke<AbortDocumentVersionUploadRequest,AbortDocumentVersionUploadResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AbortDocumentVersionUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AbortDocumentVersionUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/AbortDocumentVersionUpload">REST API Reference for AbortDocumentVersionUpload Operation</seealso>
        public virtual Task<AbortDocumentVersionUploadResponse> AbortDocumentVersionUploadAsync(AbortDocumentVersionUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AbortDocumentVersionUploadRequestMarshaller.Instance;
            var unmarshaller = AbortDocumentVersionUploadResponseUnmarshaller.Instance;

            return InvokeAsync<AbortDocumentVersionUploadRequest,AbortDocumentVersionUploadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ActivateUser


        /// <summary>
        /// Activates the specified user. Only active users can access Amazon WorkDocs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateUser service method.</param>
        /// 
        /// <returns>The response from the ActivateUser service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/ActivateUser">REST API Reference for ActivateUser Operation</seealso>
        public virtual ActivateUserResponse ActivateUser(ActivateUserRequest request)
        {
            var marshaller = ActivateUserRequestMarshaller.Instance;
            var unmarshaller = ActivateUserResponseUnmarshaller.Instance;

            return Invoke<ActivateUserRequest,ActivateUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ActivateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/ActivateUser">REST API Reference for ActivateUser Operation</seealso>
        public virtual Task<ActivateUserResponse> ActivateUserAsync(ActivateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ActivateUserRequestMarshaller.Instance;
            var unmarshaller = ActivateUserResponseUnmarshaller.Instance;

            return InvokeAsync<ActivateUserRequest,ActivateUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddResourcePermissions


        /// <summary>
        /// Creates a set of permissions for the specified folder or document. The resource permissions
        /// are overwritten if the principals already have different permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddResourcePermissions service method.</param>
        /// 
        /// <returns>The response from the AddResourcePermissions service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/AddResourcePermissions">REST API Reference for AddResourcePermissions Operation</seealso>
        public virtual AddResourcePermissionsResponse AddResourcePermissions(AddResourcePermissionsRequest request)
        {
            var marshaller = AddResourcePermissionsRequestMarshaller.Instance;
            var unmarshaller = AddResourcePermissionsResponseUnmarshaller.Instance;

            return Invoke<AddResourcePermissionsRequest,AddResourcePermissionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddResourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddResourcePermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/AddResourcePermissions">REST API Reference for AddResourcePermissions Operation</seealso>
        public virtual Task<AddResourcePermissionsResponse> AddResourcePermissionsAsync(AddResourcePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AddResourcePermissionsRequestMarshaller.Instance;
            var unmarshaller = AddResourcePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<AddResourcePermissionsRequest,AddResourcePermissionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateComment


        /// <summary>
        /// Adds a new comment to the specified document version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComment service method.</param>
        /// 
        /// <returns>The response from the CreateComment service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.DocumentLockedForCommentsException">
        /// This exception is thrown when the document is locked for comments and user tries to
        /// create or delete a comment on that document.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateComment">REST API Reference for CreateComment Operation</seealso>
        public virtual CreateCommentResponse CreateComment(CreateCommentRequest request)
        {
            var marshaller = CreateCommentRequestMarshaller.Instance;
            var unmarshaller = CreateCommentResponseUnmarshaller.Instance;

            return Invoke<CreateCommentRequest,CreateCommentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateComment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateComment">REST API Reference for CreateComment Operation</seealso>
        public virtual Task<CreateCommentResponse> CreateCommentAsync(CreateCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateCommentRequestMarshaller.Instance;
            var unmarshaller = CreateCommentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCommentRequest,CreateCommentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomMetadata


        /// <summary>
        /// Adds one or more custom properties to the specified resource (a folder, document,
        /// or version).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomMetadata service method.</param>
        /// 
        /// <returns>The response from the CreateCustomMetadata service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.CustomMetadataLimitExceededException">
        /// The limit has been reached on the number of custom properties for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateCustomMetadata">REST API Reference for CreateCustomMetadata Operation</seealso>
        public virtual CreateCustomMetadataResponse CreateCustomMetadata(CreateCustomMetadataRequest request)
        {
            var marshaller = CreateCustomMetadataRequestMarshaller.Instance;
            var unmarshaller = CreateCustomMetadataResponseUnmarshaller.Instance;

            return Invoke<CreateCustomMetadataRequest,CreateCustomMetadataResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomMetadata operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateCustomMetadata">REST API Reference for CreateCustomMetadata Operation</seealso>
        public virtual Task<CreateCustomMetadataResponse> CreateCustomMetadataAsync(CreateCustomMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateCustomMetadataRequestMarshaller.Instance;
            var unmarshaller = CreateCustomMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCustomMetadataRequest,CreateCustomMetadataResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateFolder


        /// <summary>
        /// Creates a folder with the specified name and parent folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFolder service method.</param>
        /// 
        /// <returns>The response from the CreateFolder service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.LimitExceededException">
        /// The maximum of 100,000 folders under the parent folder has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateFolder">REST API Reference for CreateFolder Operation</seealso>
        public virtual CreateFolderResponse CreateFolder(CreateFolderRequest request)
        {
            var marshaller = CreateFolderRequestMarshaller.Instance;
            var unmarshaller = CreateFolderResponseUnmarshaller.Instance;

            return Invoke<CreateFolderRequest,CreateFolderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFolder operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateFolder">REST API Reference for CreateFolder Operation</seealso>
        public virtual Task<CreateFolderResponse> CreateFolderAsync(CreateFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateFolderRequestMarshaller.Instance;
            var unmarshaller = CreateFolderResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFolderRequest,CreateFolderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateLabels


        /// <summary>
        /// Adds the specified list of labels to the given resource (a document or folder)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLabels service method.</param>
        /// 
        /// <returns>The response from the CreateLabels service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.TooManyLabelsException">
        /// The limit has been reached on the number of labels for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateLabels">REST API Reference for CreateLabels Operation</seealso>
        public virtual CreateLabelsResponse CreateLabels(CreateLabelsRequest request)
        {
            var marshaller = CreateLabelsRequestMarshaller.Instance;
            var unmarshaller = CreateLabelsResponseUnmarshaller.Instance;

            return Invoke<CreateLabelsRequest,CreateLabelsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLabels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateLabels">REST API Reference for CreateLabels Operation</seealso>
        public virtual Task<CreateLabelsResponse> CreateLabelsAsync(CreateLabelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateLabelsRequestMarshaller.Instance;
            var unmarshaller = CreateLabelsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLabelsRequest,CreateLabelsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateNotificationSubscription


        /// <summary>
        /// Configure WorkDocs to use Amazon SNS notifications.
        /// 
        ///  
        /// <para>
        /// The endpoint receives a confirmation message, and must confirm the subscription. For
        /// more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SendMessageToHttp.html#SendMessageToHttp.confirm">Confirm
        /// the Subscription</a> in the <i>Amazon Simple Notification Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotificationSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateNotificationSubscription service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.TooManySubscriptionsException">
        /// You've reached the limit on the number of subscriptions for the WorkDocs instance.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateNotificationSubscription">REST API Reference for CreateNotificationSubscription Operation</seealso>
        public virtual CreateNotificationSubscriptionResponse CreateNotificationSubscription(CreateNotificationSubscriptionRequest request)
        {
            var marshaller = CreateNotificationSubscriptionRequestMarshaller.Instance;
            var unmarshaller = CreateNotificationSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateNotificationSubscriptionRequest,CreateNotificationSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNotificationSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotificationSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateNotificationSubscription">REST API Reference for CreateNotificationSubscription Operation</seealso>
        public virtual Task<CreateNotificationSubscriptionResponse> CreateNotificationSubscriptionAsync(CreateNotificationSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateNotificationSubscriptionRequestMarshaller.Instance;
            var unmarshaller = CreateNotificationSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNotificationSubscriptionRequest,CreateNotificationSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateUser


        /// <summary>
        /// Creates a user in a Simple AD or Microsoft AD directory. The status of a newly created
        /// user is "ACTIVE". New users can access Amazon WorkDocs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual CreateUserResponse CreateUser(CreateUserRequest request)
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateUserRequestMarshaller.Instance;
            var unmarshaller = CreateUserResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserRequest,CreateUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeactivateUser


        /// <summary>
        /// Deactivates the specified user, which revokes the user's access to Amazon WorkDocs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateUser service method.</param>
        /// 
        /// <returns>The response from the DeactivateUser service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeactivateUser">REST API Reference for DeactivateUser Operation</seealso>
        public virtual DeactivateUserResponse DeactivateUser(DeactivateUserRequest request)
        {
            var marshaller = DeactivateUserRequestMarshaller.Instance;
            var unmarshaller = DeactivateUserResponseUnmarshaller.Instance;

            return Invoke<DeactivateUserRequest,DeactivateUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeactivateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeactivateUser">REST API Reference for DeactivateUser Operation</seealso>
        public virtual Task<DeactivateUserResponse> DeactivateUserAsync(DeactivateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeactivateUserRequestMarshaller.Instance;
            var unmarshaller = DeactivateUserResponseUnmarshaller.Instance;

            return InvokeAsync<DeactivateUserRequest,DeactivateUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteComment


        /// <summary>
        /// Deletes the specified comment from the document version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComment service method.</param>
        /// 
        /// <returns>The response from the DeleteComment service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.DocumentLockedForCommentsException">
        /// This exception is thrown when the document is locked for comments and user tries to
        /// create or delete a comment on that document.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteComment">REST API Reference for DeleteComment Operation</seealso>
        public virtual DeleteCommentResponse DeleteComment(DeleteCommentRequest request)
        {
            var marshaller = DeleteCommentRequestMarshaller.Instance;
            var unmarshaller = DeleteCommentResponseUnmarshaller.Instance;

            return Invoke<DeleteCommentRequest,DeleteCommentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteComment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteComment">REST API Reference for DeleteComment Operation</seealso>
        public virtual Task<DeleteCommentResponse> DeleteCommentAsync(DeleteCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteCommentRequestMarshaller.Instance;
            var unmarshaller = DeleteCommentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCommentRequest,DeleteCommentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomMetadata


        /// <summary>
        /// Deletes custom metadata from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomMetadata service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomMetadata service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteCustomMetadata">REST API Reference for DeleteCustomMetadata Operation</seealso>
        public virtual DeleteCustomMetadataResponse DeleteCustomMetadata(DeleteCustomMetadataRequest request)
        {
            var marshaller = DeleteCustomMetadataRequestMarshaller.Instance;
            var unmarshaller = DeleteCustomMetadataResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomMetadataRequest,DeleteCustomMetadataResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomMetadata operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteCustomMetadata">REST API Reference for DeleteCustomMetadata Operation</seealso>
        public virtual Task<DeleteCustomMetadataResponse> DeleteCustomMetadataAsync(DeleteCustomMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteCustomMetadataRequestMarshaller.Instance;
            var unmarshaller = DeleteCustomMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCustomMetadataRequest,DeleteCustomMetadataResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDocument


        /// <summary>
        /// Permanently deletes the specified document and its associated metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocument service method.</param>
        /// 
        /// <returns>The response from the DeleteDocument service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConcurrentModificationException">
        /// The resource hierarchy is changing.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        public virtual DeleteDocumentResponse DeleteDocument(DeleteDocumentRequest request)
        {
            var marshaller = DeleteDocumentRequestMarshaller.Instance;
            var unmarshaller = DeleteDocumentResponseUnmarshaller.Instance;

            return Invoke<DeleteDocumentRequest,DeleteDocumentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocument operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        public virtual Task<DeleteDocumentResponse> DeleteDocumentAsync(DeleteDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDocumentRequestMarshaller.Instance;
            var unmarshaller = DeleteDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDocumentRequest,DeleteDocumentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteFolder


        /// <summary>
        /// Permanently deletes the specified folder and its contents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFolder service method.</param>
        /// 
        /// <returns>The response from the DeleteFolder service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConcurrentModificationException">
        /// The resource hierarchy is changing.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteFolder">REST API Reference for DeleteFolder Operation</seealso>
        public virtual DeleteFolderResponse DeleteFolder(DeleteFolderRequest request)
        {
            var marshaller = DeleteFolderRequestMarshaller.Instance;
            var unmarshaller = DeleteFolderResponseUnmarshaller.Instance;

            return Invoke<DeleteFolderRequest,DeleteFolderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFolder operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteFolder">REST API Reference for DeleteFolder Operation</seealso>
        public virtual Task<DeleteFolderResponse> DeleteFolderAsync(DeleteFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteFolderRequestMarshaller.Instance;
            var unmarshaller = DeleteFolderResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFolderRequest,DeleteFolderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteFolderContents


        /// <summary>
        /// Deletes the contents of the specified folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFolderContents service method.</param>
        /// 
        /// <returns>The response from the DeleteFolderContents service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteFolderContents">REST API Reference for DeleteFolderContents Operation</seealso>
        public virtual DeleteFolderContentsResponse DeleteFolderContents(DeleteFolderContentsRequest request)
        {
            var marshaller = DeleteFolderContentsRequestMarshaller.Instance;
            var unmarshaller = DeleteFolderContentsResponseUnmarshaller.Instance;

            return Invoke<DeleteFolderContentsRequest,DeleteFolderContentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFolderContents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFolderContents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteFolderContents">REST API Reference for DeleteFolderContents Operation</seealso>
        public virtual Task<DeleteFolderContentsResponse> DeleteFolderContentsAsync(DeleteFolderContentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteFolderContentsRequestMarshaller.Instance;
            var unmarshaller = DeleteFolderContentsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFolderContentsRequest,DeleteFolderContentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteLabels


        /// <summary>
        /// Deletes the specified list of labels from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabels service method.</param>
        /// 
        /// <returns>The response from the DeleteLabels service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteLabels">REST API Reference for DeleteLabels Operation</seealso>
        public virtual DeleteLabelsResponse DeleteLabels(DeleteLabelsRequest request)
        {
            var marshaller = DeleteLabelsRequestMarshaller.Instance;
            var unmarshaller = DeleteLabelsResponseUnmarshaller.Instance;

            return Invoke<DeleteLabelsRequest,DeleteLabelsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteLabels">REST API Reference for DeleteLabels Operation</seealso>
        public virtual Task<DeleteLabelsResponse> DeleteLabelsAsync(DeleteLabelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteLabelsRequestMarshaller.Instance;
            var unmarshaller = DeleteLabelsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLabelsRequest,DeleteLabelsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteNotificationSubscription


        /// <summary>
        /// Deletes the specified subscription from the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteNotificationSubscription service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteNotificationSubscription">REST API Reference for DeleteNotificationSubscription Operation</seealso>
        public virtual DeleteNotificationSubscriptionResponse DeleteNotificationSubscription(DeleteNotificationSubscriptionRequest request)
        {
            var marshaller = DeleteNotificationSubscriptionRequestMarshaller.Instance;
            var unmarshaller = DeleteNotificationSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteNotificationSubscriptionRequest,DeleteNotificationSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotificationSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteNotificationSubscription">REST API Reference for DeleteNotificationSubscription Operation</seealso>
        public virtual Task<DeleteNotificationSubscriptionResponse> DeleteNotificationSubscriptionAsync(DeleteNotificationSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteNotificationSubscriptionRequestMarshaller.Instance;
            var unmarshaller = DeleteNotificationSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNotificationSubscriptionRequest,DeleteNotificationSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Deletes the specified user from a Simple AD or Microsoft AD directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteUserRequestMarshaller.Instance;
            var unmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserRequest,DeleteUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeActivities


        /// <summary>
        /// Describes the user activities in a specified time period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivities service method.</param>
        /// 
        /// <returns>The response from the DescribeActivities service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeActivities">REST API Reference for DescribeActivities Operation</seealso>
        public virtual DescribeActivitiesResponse DescribeActivities(DescribeActivitiesRequest request)
        {
            var marshaller = DescribeActivitiesRequestMarshaller.Instance;
            var unmarshaller = DescribeActivitiesResponseUnmarshaller.Instance;

            return Invoke<DescribeActivitiesRequest,DescribeActivitiesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeActivities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeActivities">REST API Reference for DescribeActivities Operation</seealso>
        public virtual Task<DescribeActivitiesResponse> DescribeActivitiesAsync(DescribeActivitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeActivitiesRequestMarshaller.Instance;
            var unmarshaller = DescribeActivitiesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeActivitiesRequest,DescribeActivitiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeComments


        /// <summary>
        /// List all the comments for the specified document version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComments service method.</param>
        /// 
        /// <returns>The response from the DescribeComments service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeComments">REST API Reference for DescribeComments Operation</seealso>
        public virtual DescribeCommentsResponse DescribeComments(DescribeCommentsRequest request)
        {
            var marshaller = DescribeCommentsRequestMarshaller.Instance;
            var unmarshaller = DescribeCommentsResponseUnmarshaller.Instance;

            return Invoke<DescribeCommentsRequest,DescribeCommentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeComments">REST API Reference for DescribeComments Operation</seealso>
        public virtual Task<DescribeCommentsResponse> DescribeCommentsAsync(DescribeCommentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeCommentsRequestMarshaller.Instance;
            var unmarshaller = DescribeCommentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCommentsRequest,DescribeCommentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDocumentVersions


        /// <summary>
        /// Retrieves the document versions for the specified document.
        /// 
        ///  
        /// <para>
        /// By default, only active versions are returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeDocumentVersions service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeDocumentVersions">REST API Reference for DescribeDocumentVersions Operation</seealso>
        public virtual DescribeDocumentVersionsResponse DescribeDocumentVersions(DescribeDocumentVersionsRequest request)
        {
            var marshaller = DescribeDocumentVersionsRequestMarshaller.Instance;
            var unmarshaller = DescribeDocumentVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDocumentVersionsRequest,DescribeDocumentVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDocumentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeDocumentVersions">REST API Reference for DescribeDocumentVersions Operation</seealso>
        public virtual Task<DescribeDocumentVersionsResponse> DescribeDocumentVersionsAsync(DescribeDocumentVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDocumentVersionsRequestMarshaller.Instance;
            var unmarshaller = DescribeDocumentVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDocumentVersionsRequest,DescribeDocumentVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeFolderContents


        /// <summary>
        /// Describes the contents of the specified folder, including its documents and subfolders.
        /// 
        ///  
        /// <para>
        /// By default, Amazon WorkDocs returns the first 100 active document and folder metadata
        /// items. If there are more results, the response includes a marker that you can use
        /// to request the next set of results. You can also request initialized documents.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFolderContents service method.</param>
        /// 
        /// <returns>The response from the DescribeFolderContents service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeFolderContents">REST API Reference for DescribeFolderContents Operation</seealso>
        public virtual DescribeFolderContentsResponse DescribeFolderContents(DescribeFolderContentsRequest request)
        {
            var marshaller = DescribeFolderContentsRequestMarshaller.Instance;
            var unmarshaller = DescribeFolderContentsResponseUnmarshaller.Instance;

            return Invoke<DescribeFolderContentsRequest,DescribeFolderContentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFolderContents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFolderContents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeFolderContents">REST API Reference for DescribeFolderContents Operation</seealso>
        public virtual Task<DescribeFolderContentsResponse> DescribeFolderContentsAsync(DescribeFolderContentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeFolderContentsRequestMarshaller.Instance;
            var unmarshaller = DescribeFolderContentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFolderContentsRequest,DescribeFolderContentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeGroups


        /// <summary>
        /// Describes the groups specified by query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeGroups service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeGroups">REST API Reference for DescribeGroups Operation</seealso>
        public virtual DescribeGroupsResponse DescribeGroups(DescribeGroupsRequest request)
        {
            var marshaller = DescribeGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeGroupsRequest,DescribeGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeGroups">REST API Reference for DescribeGroups Operation</seealso>
        public virtual Task<DescribeGroupsResponse> DescribeGroupsAsync(DescribeGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGroupsRequest,DescribeGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeNotificationSubscriptions


        /// <summary>
        /// Lists the specified notification subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationSubscriptions service method.</param>
        /// 
        /// <returns>The response from the DescribeNotificationSubscriptions service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeNotificationSubscriptions">REST API Reference for DescribeNotificationSubscriptions Operation</seealso>
        public virtual DescribeNotificationSubscriptionsResponse DescribeNotificationSubscriptions(DescribeNotificationSubscriptionsRequest request)
        {
            var marshaller = DescribeNotificationSubscriptionsRequestMarshaller.Instance;
            var unmarshaller = DescribeNotificationSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeNotificationSubscriptionsRequest,DescribeNotificationSubscriptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotificationSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationSubscriptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeNotificationSubscriptions">REST API Reference for DescribeNotificationSubscriptions Operation</seealso>
        public virtual Task<DescribeNotificationSubscriptionsResponse> DescribeNotificationSubscriptionsAsync(DescribeNotificationSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeNotificationSubscriptionsRequestMarshaller.Instance;
            var unmarshaller = DescribeNotificationSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNotificationSubscriptionsRequest,DescribeNotificationSubscriptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeResourcePermissions


        /// <summary>
        /// Describes the permissions of a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeResourcePermissions service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeResourcePermissions">REST API Reference for DescribeResourcePermissions Operation</seealso>
        public virtual DescribeResourcePermissionsResponse DescribeResourcePermissions(DescribeResourcePermissionsRequest request)
        {
            var marshaller = DescribeResourcePermissionsRequestMarshaller.Instance;
            var unmarshaller = DescribeResourcePermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeResourcePermissionsRequest,DescribeResourcePermissionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeResourcePermissions">REST API Reference for DescribeResourcePermissions Operation</seealso>
        public virtual Task<DescribeResourcePermissionsResponse> DescribeResourcePermissionsAsync(DescribeResourcePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeResourcePermissionsRequestMarshaller.Instance;
            var unmarshaller = DescribeResourcePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResourcePermissionsRequest,DescribeResourcePermissionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRootFolders


        /// <summary>
        /// Describes the current user's special folders; the <code>RootFolder</code> and the
        /// <code>RecycleBin</code>. <code>RootFolder</code> is the root of user's files and folders
        /// and <code>RecycleBin</code> is the root of recycled items. This is not a valid action
        /// for SigV4 (administrative API) clients.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRootFolders service method.</param>
        /// 
        /// <returns>The response from the DescribeRootFolders service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeRootFolders">REST API Reference for DescribeRootFolders Operation</seealso>
        public virtual DescribeRootFoldersResponse DescribeRootFolders(DescribeRootFoldersRequest request)
        {
            var marshaller = DescribeRootFoldersRequestMarshaller.Instance;
            var unmarshaller = DescribeRootFoldersResponseUnmarshaller.Instance;

            return Invoke<DescribeRootFoldersRequest,DescribeRootFoldersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRootFolders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRootFolders operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeRootFolders">REST API Reference for DescribeRootFolders Operation</seealso>
        public virtual Task<DescribeRootFoldersResponse> DescribeRootFoldersAsync(DescribeRootFoldersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeRootFoldersRequestMarshaller.Instance;
            var unmarshaller = DescribeRootFoldersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRootFoldersRequest,DescribeRootFoldersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeUsers


        /// <summary>
        /// Describes the specified users. You can describe all users or filter the results (for
        /// example, by status or organization).
        /// 
        ///  
        /// <para>
        /// By default, Amazon WorkDocs returns the first 24 active or pending users. If there
        /// are more results, the response includes a marker that you can use to request the next
        /// set of results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUsers service method.</param>
        /// 
        /// <returns>The response from the DescribeUsers service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeUsers">REST API Reference for DescribeUsers Operation</seealso>
        public virtual DescribeUsersResponse DescribeUsers(DescribeUsersRequest request)
        {
            var marshaller = DescribeUsersRequestMarshaller.Instance;
            var unmarshaller = DescribeUsersResponseUnmarshaller.Instance;

            return Invoke<DescribeUsersRequest,DescribeUsersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUsers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DescribeUsers">REST API Reference for DescribeUsers Operation</seealso>
        public virtual Task<DescribeUsersResponse> DescribeUsersAsync(DescribeUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeUsersRequestMarshaller.Instance;
            var unmarshaller = DescribeUsersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUsersRequest,DescribeUsersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCurrentUser


        /// <summary>
        /// Retrieves details of the current user for whom the authentication token was generated.
        /// This is not a valid action for SigV4 (administrative API) clients.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCurrentUser service method.</param>
        /// 
        /// <returns>The response from the GetCurrentUser service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetCurrentUser">REST API Reference for GetCurrentUser Operation</seealso>
        public virtual GetCurrentUserResponse GetCurrentUser(GetCurrentUserRequest request)
        {
            var marshaller = GetCurrentUserRequestMarshaller.Instance;
            var unmarshaller = GetCurrentUserResponseUnmarshaller.Instance;

            return Invoke<GetCurrentUserRequest,GetCurrentUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCurrentUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCurrentUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetCurrentUser">REST API Reference for GetCurrentUser Operation</seealso>
        public virtual Task<GetCurrentUserResponse> GetCurrentUserAsync(GetCurrentUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetCurrentUserRequestMarshaller.Instance;
            var unmarshaller = GetCurrentUserResponseUnmarshaller.Instance;

            return InvokeAsync<GetCurrentUserRequest,GetCurrentUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDocument


        /// <summary>
        /// Retrieves details of a document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocument service method.</param>
        /// 
        /// <returns>The response from the GetDocument service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidPasswordException">
        /// The password is invalid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetDocument">REST API Reference for GetDocument Operation</seealso>
        public virtual GetDocumentResponse GetDocument(GetDocumentRequest request)
        {
            var marshaller = GetDocumentRequestMarshaller.Instance;
            var unmarshaller = GetDocumentResponseUnmarshaller.Instance;

            return Invoke<GetDocumentRequest,GetDocumentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocument operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetDocument">REST API Reference for GetDocument Operation</seealso>
        public virtual Task<GetDocumentResponse> GetDocumentAsync(GetDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDocumentRequestMarshaller.Instance;
            var unmarshaller = GetDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<GetDocumentRequest,GetDocumentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDocumentPath


        /// <summary>
        /// Retrieves the path information (the hierarchy from the root folder) for the requested
        /// document.
        /// 
        ///  
        /// <para>
        /// By default, Amazon WorkDocs returns a maximum of 100 levels upwards from the requested
        /// document and only includes the IDs of the parent folders in the path. You can limit
        /// the maximum number of levels. You can also request the names of the parent folders.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentPath service method.</param>
        /// 
        /// <returns>The response from the GetDocumentPath service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetDocumentPath">REST API Reference for GetDocumentPath Operation</seealso>
        public virtual GetDocumentPathResponse GetDocumentPath(GetDocumentPathRequest request)
        {
            var marshaller = GetDocumentPathRequestMarshaller.Instance;
            var unmarshaller = GetDocumentPathResponseUnmarshaller.Instance;

            return Invoke<GetDocumentPathRequest,GetDocumentPathResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentPath operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentPath operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetDocumentPath">REST API Reference for GetDocumentPath Operation</seealso>
        public virtual Task<GetDocumentPathResponse> GetDocumentPathAsync(GetDocumentPathRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDocumentPathRequestMarshaller.Instance;
            var unmarshaller = GetDocumentPathResponseUnmarshaller.Instance;

            return InvokeAsync<GetDocumentPathRequest,GetDocumentPathResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDocumentVersion


        /// <summary>
        /// Retrieves version metadata for the specified document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentVersion service method.</param>
        /// 
        /// <returns>The response from the GetDocumentVersion service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidPasswordException">
        /// The password is invalid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetDocumentVersion">REST API Reference for GetDocumentVersion Operation</seealso>
        public virtual GetDocumentVersionResponse GetDocumentVersion(GetDocumentVersionRequest request)
        {
            var marshaller = GetDocumentVersionRequestMarshaller.Instance;
            var unmarshaller = GetDocumentVersionResponseUnmarshaller.Instance;

            return Invoke<GetDocumentVersionRequest,GetDocumentVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetDocumentVersion">REST API Reference for GetDocumentVersion Operation</seealso>
        public virtual Task<GetDocumentVersionResponse> GetDocumentVersionAsync(GetDocumentVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDocumentVersionRequestMarshaller.Instance;
            var unmarshaller = GetDocumentVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetDocumentVersionRequest,GetDocumentVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFolder


        /// <summary>
        /// Retrieves the metadata of the specified folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFolder service method.</param>
        /// 
        /// <returns>The response from the GetFolder service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetFolder">REST API Reference for GetFolder Operation</seealso>
        public virtual GetFolderResponse GetFolder(GetFolderRequest request)
        {
            var marshaller = GetFolderRequestMarshaller.Instance;
            var unmarshaller = GetFolderResponseUnmarshaller.Instance;

            return Invoke<GetFolderRequest,GetFolderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFolder operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetFolder">REST API Reference for GetFolder Operation</seealso>
        public virtual Task<GetFolderResponse> GetFolderAsync(GetFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetFolderRequestMarshaller.Instance;
            var unmarshaller = GetFolderResponseUnmarshaller.Instance;

            return InvokeAsync<GetFolderRequest,GetFolderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFolderPath


        /// <summary>
        /// Retrieves the path information (the hierarchy from the root folder) for the specified
        /// folder.
        /// 
        ///  
        /// <para>
        /// By default, Amazon WorkDocs returns a maximum of 100 levels upwards from the requested
        /// folder and only includes the IDs of the parent folders in the path. You can limit
        /// the maximum number of levels. You can also request the parent folder names.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFolderPath service method.</param>
        /// 
        /// <returns>The response from the GetFolderPath service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetFolderPath">REST API Reference for GetFolderPath Operation</seealso>
        public virtual GetFolderPathResponse GetFolderPath(GetFolderPathRequest request)
        {
            var marshaller = GetFolderPathRequestMarshaller.Instance;
            var unmarshaller = GetFolderPathResponseUnmarshaller.Instance;

            return Invoke<GetFolderPathRequest,GetFolderPathResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFolderPath operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFolderPath operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetFolderPath">REST API Reference for GetFolderPath Operation</seealso>
        public virtual Task<GetFolderPathResponse> GetFolderPathAsync(GetFolderPathRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetFolderPathRequestMarshaller.Instance;
            var unmarshaller = GetFolderPathResponseUnmarshaller.Instance;

            return InvokeAsync<GetFolderPathRequest,GetFolderPathResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  InitiateDocumentVersionUpload


        /// <summary>
        /// Creates a new document object and version object.
        /// 
        ///  
        /// <para>
        /// The client specifies the parent folder ID and name of the document to upload. The
        /// ID is optionally specified when creating a new version of an existing document. This
        /// is the first step to upload a document. Next, upload the document to the URL returned
        /// from the call, and then call <a>UpdateDocumentVersion</a>.
        /// </para>
        ///  
        /// <para>
        /// To cancel the document upload, call <a>AbortDocumentVersionUpload</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateDocumentVersionUpload service method.</param>
        /// 
        /// <returns>The response from the InitiateDocumentVersionUpload service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.DraftUploadOutOfSyncException">
        /// This exception is thrown when a valid checkout ID is not presented on document version
        /// upload calls for a document that has been checked out from Web client.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ResourceAlreadyCheckedOutException">
        /// The resource is already checked out.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.StorageLimitExceededException">
        /// The storage limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.StorageLimitWillExceedException">
        /// The storage limit will be exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/InitiateDocumentVersionUpload">REST API Reference for InitiateDocumentVersionUpload Operation</seealso>
        public virtual InitiateDocumentVersionUploadResponse InitiateDocumentVersionUpload(InitiateDocumentVersionUploadRequest request)
        {
            var marshaller = InitiateDocumentVersionUploadRequestMarshaller.Instance;
            var unmarshaller = InitiateDocumentVersionUploadResponseUnmarshaller.Instance;

            return Invoke<InitiateDocumentVersionUploadRequest,InitiateDocumentVersionUploadResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateDocumentVersionUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateDocumentVersionUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/InitiateDocumentVersionUpload">REST API Reference for InitiateDocumentVersionUpload Operation</seealso>
        public virtual Task<InitiateDocumentVersionUploadResponse> InitiateDocumentVersionUploadAsync(InitiateDocumentVersionUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = InitiateDocumentVersionUploadRequestMarshaller.Instance;
            var unmarshaller = InitiateDocumentVersionUploadResponseUnmarshaller.Instance;

            return InvokeAsync<InitiateDocumentVersionUploadRequest,InitiateDocumentVersionUploadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveAllResourcePermissions


        /// <summary>
        /// Removes all the permissions from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAllResourcePermissions service method.</param>
        /// 
        /// <returns>The response from the RemoveAllResourcePermissions service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/RemoveAllResourcePermissions">REST API Reference for RemoveAllResourcePermissions Operation</seealso>
        public virtual RemoveAllResourcePermissionsResponse RemoveAllResourcePermissions(RemoveAllResourcePermissionsRequest request)
        {
            var marshaller = RemoveAllResourcePermissionsRequestMarshaller.Instance;
            var unmarshaller = RemoveAllResourcePermissionsResponseUnmarshaller.Instance;

            return Invoke<RemoveAllResourcePermissionsRequest,RemoveAllResourcePermissionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveAllResourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveAllResourcePermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/RemoveAllResourcePermissions">REST API Reference for RemoveAllResourcePermissions Operation</seealso>
        public virtual Task<RemoveAllResourcePermissionsResponse> RemoveAllResourcePermissionsAsync(RemoveAllResourcePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RemoveAllResourcePermissionsRequestMarshaller.Instance;
            var unmarshaller = RemoveAllResourcePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveAllResourcePermissionsRequest,RemoveAllResourcePermissionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveResourcePermission


        /// <summary>
        /// Removes the permission for the specified principal from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveResourcePermission service method.</param>
        /// 
        /// <returns>The response from the RemoveResourcePermission service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/RemoveResourcePermission">REST API Reference for RemoveResourcePermission Operation</seealso>
        public virtual RemoveResourcePermissionResponse RemoveResourcePermission(RemoveResourcePermissionRequest request)
        {
            var marshaller = RemoveResourcePermissionRequestMarshaller.Instance;
            var unmarshaller = RemoveResourcePermissionResponseUnmarshaller.Instance;

            return Invoke<RemoveResourcePermissionRequest,RemoveResourcePermissionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveResourcePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveResourcePermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/RemoveResourcePermission">REST API Reference for RemoveResourcePermission Operation</seealso>
        public virtual Task<RemoveResourcePermissionResponse> RemoveResourcePermissionAsync(RemoveResourcePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RemoveResourcePermissionRequestMarshaller.Instance;
            var unmarshaller = RemoveResourcePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveResourcePermissionRequest,RemoveResourcePermissionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDocument


        /// <summary>
        /// Updates the specified attributes of a document. The user must have access to both
        /// the document and its parent folder, if applicable.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocument service method.</param>
        /// 
        /// <returns>The response from the UpdateDocument service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConcurrentModificationException">
        /// The resource hierarchy is changing.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.LimitExceededException">
        /// The maximum of 100,000 folders under the parent folder has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/UpdateDocument">REST API Reference for UpdateDocument Operation</seealso>
        public virtual UpdateDocumentResponse UpdateDocument(UpdateDocumentRequest request)
        {
            var marshaller = UpdateDocumentRequestMarshaller.Instance;
            var unmarshaller = UpdateDocumentResponseUnmarshaller.Instance;

            return Invoke<UpdateDocumentRequest,UpdateDocumentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocument operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/UpdateDocument">REST API Reference for UpdateDocument Operation</seealso>
        public virtual Task<UpdateDocumentResponse> UpdateDocumentAsync(UpdateDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateDocumentRequestMarshaller.Instance;
            var unmarshaller = UpdateDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDocumentRequest,UpdateDocumentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDocumentVersion


        /// <summary>
        /// Changes the status of the document version to ACTIVE. 
        /// 
        ///  
        /// <para>
        /// Amazon WorkDocs also sets its document container to ACTIVE. This is the last step
        /// in a document upload, after the client uploads the document to an S3-presigned URL
        /// returned by <a>InitiateDocumentVersionUpload</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateDocumentVersion service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConcurrentModificationException">
        /// The resource hierarchy is changing.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidOperationException">
        /// The operation is invalid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/UpdateDocumentVersion">REST API Reference for UpdateDocumentVersion Operation</seealso>
        public virtual UpdateDocumentVersionResponse UpdateDocumentVersion(UpdateDocumentVersionRequest request)
        {
            var marshaller = UpdateDocumentVersionRequestMarshaller.Instance;
            var unmarshaller = UpdateDocumentVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateDocumentVersionRequest,UpdateDocumentVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDocumentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/UpdateDocumentVersion">REST API Reference for UpdateDocumentVersion Operation</seealso>
        public virtual Task<UpdateDocumentVersionResponse> UpdateDocumentVersionAsync(UpdateDocumentVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateDocumentVersionRequestMarshaller.Instance;
            var unmarshaller = UpdateDocumentVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDocumentVersionRequest,UpdateDocumentVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateFolder


        /// <summary>
        /// Updates the specified attributes of the specified folder. The user must have access
        /// to both the folder and its parent folder, if applicable.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFolder service method.</param>
        /// 
        /// <returns>The response from the UpdateFolder service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConcurrentModificationException">
        /// The resource hierarchy is changing.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.LimitExceededException">
        /// The maximum of 100,000 folders under the parent folder has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ProhibitedStateException">
        /// The specified document version is not in the INITIALIZED state.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/UpdateFolder">REST API Reference for UpdateFolder Operation</seealso>
        public virtual UpdateFolderResponse UpdateFolder(UpdateFolderRequest request)
        {
            var marshaller = UpdateFolderRequestMarshaller.Instance;
            var unmarshaller = UpdateFolderResponseUnmarshaller.Instance;

            return Invoke<UpdateFolderRequest,UpdateFolderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFolder operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/UpdateFolder">REST API Reference for UpdateFolder Operation</seealso>
        public virtual Task<UpdateFolderResponse> UpdateFolderAsync(UpdateFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateFolderRequestMarshaller.Instance;
            var unmarshaller = UpdateFolderResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFolderRequest,UpdateFolderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateUser


        /// <summary>
        /// Updates the specified attributes of the specified user, and grants or revokes administrative
        /// privileges to the Amazon WorkDocs site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.DeactivatingLastSystemUserException">
        /// The last user in the organization is being deactivated.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.EntityNotExistsException">
        /// The resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.FailedDependencyException">
        /// The AWS Directory Service cannot reach an on-premises instance. Or a dependency under
        /// the control of the organization is failing, such as a connected Active Directory.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.IllegalUserStateException">
        /// The user is undergoing transfer of ownership.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.InvalidArgumentException">
        /// The pagination marker or limit fields are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ServiceUnavailableException">
        /// One or more of the dependencies is unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedOperationException">
        /// The operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.UnauthorizedResourceAccessException">
        /// The caller does not have access to perform the action on the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            var marshaller = UpdateUserRequestMarshaller.Instance;
            var unmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return Invoke<UpdateUserRequest,UpdateUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateUserRequestMarshaller.Instance;
            var unmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserRequest,UpdateUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}