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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.WorkDocs.Model;
using Amazon.WorkDocs.Model.Internal.MarshallTransformations;
using Amazon.WorkDocs.Internal;
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
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonWorkDocsClient : AmazonServiceClient, IAmazonWorkDocs
    {
        private static IServiceMetadata serviceMetadata = new AmazonWorkDocsMetadata();
        
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
#if AWS_ASYNC_ENUMERABLES_API
        private IWorkDocsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IWorkDocsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new WorkDocsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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


        #region  AbortDocumentVersionUpload

        internal virtual AbortDocumentVersionUploadResponse AbortDocumentVersionUpload(AbortDocumentVersionUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AbortDocumentVersionUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortDocumentVersionUploadResponseUnmarshaller.Instance;

            return Invoke<AbortDocumentVersionUploadResponse>(request, options);
        }



        /// <summary>
        /// Aborts the upload of the specified document version that was previously initiated
        /// by <a>InitiateDocumentVersionUpload</a>. The client should make this call only when
        /// it no longer intends to upload the document version, or fails to do so.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AbortDocumentVersionUpload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AbortDocumentVersionUploadResponse> AbortDocumentVersionUploadAsync(AbortDocumentVersionUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AbortDocumentVersionUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortDocumentVersionUploadResponseUnmarshaller.Instance;

            return InvokeAsync<AbortDocumentVersionUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ActivateUser

        internal virtual ActivateUserResponse ActivateUser(ActivateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ActivateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateUserResponseUnmarshaller.Instance;

            return Invoke<ActivateUserResponse>(request, options);
        }



        /// <summary>
        /// Activates the specified user. Only active users can access Amazon WorkDocs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ActivateUserResponse> ActivateUserAsync(ActivateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ActivateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateUserResponseUnmarshaller.Instance;

            return InvokeAsync<ActivateUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddResourcePermissions

        internal virtual AddResourcePermissionsResponse AddResourcePermissions(AddResourcePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddResourcePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddResourcePermissionsResponseUnmarshaller.Instance;

            return Invoke<AddResourcePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Creates a set of permissions for the specified folder or document. The resource permissions
        /// are overwritten if the principals already have different permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddResourcePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AddResourcePermissionsResponse> AddResourcePermissionsAsync(AddResourcePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddResourcePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddResourcePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<AddResourcePermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateComment

        internal virtual CreateCommentResponse CreateComment(CreateCommentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCommentResponseUnmarshaller.Instance;

            return Invoke<CreateCommentResponse>(request, options);
        }



        /// <summary>
        /// Adds a new comment to the specified document version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <exception cref="Amazon.WorkDocs.Model.InvalidCommentOperationException">
        /// The requested operation is not allowed on the specified comment object.
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
        public virtual Task<CreateCommentResponse> CreateCommentAsync(CreateCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCommentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCommentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomMetadata

        internal virtual CreateCustomMetadataResponse CreateCustomMetadata(CreateCustomMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomMetadataResponseUnmarshaller.Instance;

            return Invoke<CreateCustomMetadataResponse>(request, options);
        }



        /// <summary>
        /// Adds one or more custom properties to the specified resource (a folder, document,
        /// or version).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateCustomMetadataResponse> CreateCustomMetadataAsync(CreateCustomMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCustomMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFolder

        internal virtual CreateFolderResponse CreateFolder(CreateFolderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFolderResponseUnmarshaller.Instance;

            return Invoke<CreateFolderResponse>(request, options);
        }



        /// <summary>
        /// Creates a folder with the specified name and parent folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFolder service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConflictingOperationException">
        /// Another operation is in progress on the resource that conflicts with the current operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/CreateFolder">REST API Reference for CreateFolder Operation</seealso>
        public virtual Task<CreateFolderResponse> CreateFolderAsync(CreateFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFolderResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFolderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLabels

        internal virtual CreateLabelsResponse CreateLabels(CreateLabelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLabelsResponseUnmarshaller.Instance;

            return Invoke<CreateLabelsResponse>(request, options);
        }



        /// <summary>
        /// Adds the specified list of labels to the given resource (a document or folder)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLabels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateLabelsResponse> CreateLabelsAsync(CreateLabelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLabelsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLabelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNotificationSubscription

        internal virtual CreateNotificationSubscriptionResponse CreateNotificationSubscription(CreateNotificationSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotificationSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotificationSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateNotificationSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Configure Amazon WorkDocs to use Amazon SNS notifications. The endpoint receives a
        /// confirmation message, and must confirm the subscription.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/workdocs/latest/developerguide/subscribe-notifications.html">Subscribe
        /// to Notifications</a> in the <i>Amazon WorkDocs Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotificationSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateNotificationSubscriptionResponse> CreateNotificationSubscriptionAsync(CreateNotificationSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotificationSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotificationSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNotificationSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateUser

        internal virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserResponse>(request, options);
        }



        /// <summary>
        /// Creates a user in a Simple AD or Microsoft AD directory. The status of a newly created
        /// user is "ACTIVE". New users can access Amazon WorkDocs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeactivateUser

        internal virtual DeactivateUserResponse DeactivateUser(DeactivateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeactivateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateUserResponseUnmarshaller.Instance;

            return Invoke<DeactivateUserResponse>(request, options);
        }



        /// <summary>
        /// Deactivates the specified user, which revokes the user's access to Amazon WorkDocs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeactivateUserResponse> DeactivateUserAsync(DeactivateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeactivateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateUserResponseUnmarshaller.Instance;

            return InvokeAsync<DeactivateUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteComment

        internal virtual DeleteCommentResponse DeleteComment(DeleteCommentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCommentResponseUnmarshaller.Instance;

            return Invoke<DeleteCommentResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified comment from the document version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteCommentResponse> DeleteCommentAsync(DeleteCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCommentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCommentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomMetadata

        internal virtual DeleteCustomMetadataResponse DeleteCustomMetadata(DeleteCustomMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomMetadataResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomMetadataResponse>(request, options);
        }



        /// <summary>
        /// Deletes custom metadata from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteCustomMetadataResponse> DeleteCustomMetadataAsync(DeleteCustomMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCustomMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDocument

        internal virtual DeleteDocumentResponse DeleteDocument(DeleteDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDocumentResponseUnmarshaller.Instance;

            return Invoke<DeleteDocumentResponse>(request, options);
        }



        /// <summary>
        /// Permanently deletes the specified document and its associated metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDocument service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConcurrentModificationException">
        /// The resource hierarchy is changing.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ConflictingOperationException">
        /// Another operation is in progress on the resource that conflicts with the current operation.
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
        public virtual Task<DeleteDocumentResponse> DeleteDocumentAsync(DeleteDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDocumentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFolder

        internal virtual DeleteFolderResponse DeleteFolder(DeleteFolderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFolderResponseUnmarshaller.Instance;

            return Invoke<DeleteFolderResponse>(request, options);
        }



        /// <summary>
        /// Permanently deletes the specified folder and its contents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFolder service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConcurrentModificationException">
        /// The resource hierarchy is changing.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ConflictingOperationException">
        /// Another operation is in progress on the resource that conflicts with the current operation.
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
        public virtual Task<DeleteFolderResponse> DeleteFolderAsync(DeleteFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFolderResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFolderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFolderContents

        internal virtual DeleteFolderContentsResponse DeleteFolderContents(DeleteFolderContentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFolderContentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFolderContentsResponseUnmarshaller.Instance;

            return Invoke<DeleteFolderContentsResponse>(request, options);
        }



        /// <summary>
        /// Deletes the contents of the specified folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFolderContents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFolderContents service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConflictingOperationException">
        /// Another operation is in progress on the resource that conflicts with the current operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/DeleteFolderContents">REST API Reference for DeleteFolderContents Operation</seealso>
        public virtual Task<DeleteFolderContentsResponse> DeleteFolderContentsAsync(DeleteFolderContentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFolderContentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFolderContentsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFolderContentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLabels

        internal virtual DeleteLabelsResponse DeleteLabels(DeleteLabelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLabelsResponseUnmarshaller.Instance;

            return Invoke<DeleteLabelsResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified list of labels from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteLabelsResponse> DeleteLabelsAsync(DeleteLabelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLabelsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLabelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNotificationSubscription

        internal virtual DeleteNotificationSubscriptionResponse DeleteNotificationSubscription(DeleteNotificationSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotificationSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteNotificationSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified subscription from the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteNotificationSubscriptionResponse> DeleteNotificationSubscriptionAsync(DeleteNotificationSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotificationSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNotificationSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUser

        internal virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified user from a Simple AD or Microsoft AD directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeActivities

        internal virtual DescribeActivitiesResponse DescribeActivities(DescribeActivitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActivitiesResponseUnmarshaller.Instance;

            return Invoke<DescribeActivitiesResponse>(request, options);
        }



        /// <summary>
        /// Describes the user activities in a specified time period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeActivitiesResponse> DescribeActivitiesAsync(DescribeActivitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActivitiesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeActivitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeComments

        internal virtual DescribeCommentsResponse DescribeComments(DescribeCommentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCommentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCommentsResponseUnmarshaller.Instance;

            return Invoke<DescribeCommentsResponse>(request, options);
        }



        /// <summary>
        /// List all the comments for the specified document version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeCommentsResponse> DescribeCommentsAsync(DescribeCommentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCommentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCommentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCommentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDocumentVersions

        internal virtual DescribeDocumentVersionsResponse DescribeDocumentVersions(DescribeDocumentVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDocumentVersionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the document versions for the specified document.
        /// 
        ///  
        /// <para>
        /// By default, only active versions are returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeDocumentVersionsResponse> DescribeDocumentVersionsAsync(DescribeDocumentVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDocumentVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFolderContents

        internal virtual DescribeFolderContentsResponse DescribeFolderContents(DescribeFolderContentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFolderContentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFolderContentsResponseUnmarshaller.Instance;

            return Invoke<DescribeFolderContentsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeFolderContentsResponse> DescribeFolderContentsAsync(DescribeFolderContentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFolderContentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFolderContentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFolderContentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGroups

        internal virtual DescribeGroupsResponse DescribeGroups(DescribeGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeGroupsResponse>(request, options);
        }



        /// <summary>
        /// Describes the groups specified by the query. Groups are defined by the underlying
        /// Active Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeGroupsResponse> DescribeGroupsAsync(DescribeGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNotificationSubscriptions

        internal virtual DescribeNotificationSubscriptionsResponse DescribeNotificationSubscriptions(DescribeNotificationSubscriptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotificationSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotificationSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeNotificationSubscriptionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the specified notification subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeNotificationSubscriptionsResponse> DescribeNotificationSubscriptionsAsync(DescribeNotificationSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotificationSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotificationSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNotificationSubscriptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeResourcePermissions

        internal virtual DescribeResourcePermissionsResponse DescribeResourcePermissions(DescribeResourcePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourcePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourcePermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeResourcePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Describes the permissions of a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeResourcePermissionsResponse> DescribeResourcePermissionsAsync(DescribeResourcePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourcePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourcePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResourcePermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRootFolders

        internal virtual DescribeRootFoldersResponse DescribeRootFolders(DescribeRootFoldersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRootFoldersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRootFoldersResponseUnmarshaller.Instance;

            return Invoke<DescribeRootFoldersResponse>(request, options);
        }



        /// <summary>
        /// Describes the current user's special folders; the <code>RootFolder</code> and the
        /// <code>RecycleBin</code>. <code>RootFolder</code> is the root of user's files and folders
        /// and <code>RecycleBin</code> is the root of recycled items. This is not a valid action
        /// for SigV4 (administrative API) clients.
        /// 
        ///  
        /// <para>
        /// This action requires an authentication token. To get an authentication token, register
        /// an application with Amazon WorkDocs. For more information, see <a href="https://docs.aws.amazon.com/workdocs/latest/developerguide/wd-auth-user.html">Authentication
        /// and Access Control for User Applications</a> in the <i>Amazon WorkDocs Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRootFolders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeRootFoldersResponse> DescribeRootFoldersAsync(DescribeRootFoldersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRootFoldersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRootFoldersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRootFoldersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeUsers

        internal virtual DescribeUsersResponse DescribeUsers(DescribeUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUsersResponseUnmarshaller.Instance;

            return Invoke<DescribeUsersResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUsers service method, as returned by WorkDocs.</returns>
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
        /// <exception cref="Amazon.WorkDocs.Model.RequestedEntityTooLargeException">
        /// The response is too large to return. The request must include a filter to reduce the
        /// size of the response.
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
        public virtual Task<DescribeUsersResponse> DescribeUsersAsync(DescribeUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUsersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUsersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCurrentUser

        internal virtual GetCurrentUserResponse GetCurrentUser(GetCurrentUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCurrentUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCurrentUserResponseUnmarshaller.Instance;

            return Invoke<GetCurrentUserResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details of the current user for whom the authentication token was generated.
        /// This is not a valid action for SigV4 (administrative API) clients.
        /// 
        ///  
        /// <para>
        /// This action requires an authentication token. To get an authentication token, register
        /// an application with Amazon WorkDocs. For more information, see <a href="https://docs.aws.amazon.com/workdocs/latest/developerguide/wd-auth-user.html">Authentication
        /// and Access Control for User Applications</a> in the <i>Amazon WorkDocs Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCurrentUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetCurrentUserResponse> GetCurrentUserAsync(GetCurrentUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCurrentUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCurrentUserResponseUnmarshaller.Instance;

            return InvokeAsync<GetCurrentUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDocument

        internal virtual GetDocumentResponse GetDocument(GetDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentResponseUnmarshaller.Instance;

            return Invoke<GetDocumentResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details of a document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetDocumentResponse> GetDocumentAsync(GetDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<GetDocumentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDocumentPath

        internal virtual GetDocumentPathResponse GetDocumentPath(GetDocumentPathRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDocumentPathRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentPathResponseUnmarshaller.Instance;

            return Invoke<GetDocumentPathResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetDocumentPathResponse> GetDocumentPathAsync(GetDocumentPathRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDocumentPathRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentPathResponseUnmarshaller.Instance;

            return InvokeAsync<GetDocumentPathResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDocumentVersion

        internal virtual GetDocumentVersionResponse GetDocumentVersion(GetDocumentVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDocumentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentVersionResponseUnmarshaller.Instance;

            return Invoke<GetDocumentVersionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves version metadata for the specified document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetDocumentVersionResponse> GetDocumentVersionAsync(GetDocumentVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDocumentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetDocumentVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFolder

        internal virtual GetFolderResponse GetFolder(GetFolderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFolderResponseUnmarshaller.Instance;

            return Invoke<GetFolderResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the metadata of the specified folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetFolderResponse> GetFolderAsync(GetFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFolderResponseUnmarshaller.Instance;

            return InvokeAsync<GetFolderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFolderPath

        internal virtual GetFolderPathResponse GetFolderPath(GetFolderPathRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFolderPathRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFolderPathResponseUnmarshaller.Instance;

            return Invoke<GetFolderPathResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetFolderPathResponse> GetFolderPathAsync(GetFolderPathRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFolderPathRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFolderPathResponseUnmarshaller.Instance;

            return InvokeAsync<GetFolderPathResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResources

        internal virtual GetResourcesResponse GetResources(GetResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcesResponseUnmarshaller.Instance;

            return Invoke<GetResourcesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a collection of resources, including folders and documents. The only <code>CollectionType</code>
        /// supported is <code>SHARED_WITH_ME</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResources service method, as returned by WorkDocs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workdocs-2016-05-01/GetResources">REST API Reference for GetResources Operation</seealso>
        public virtual Task<GetResourcesResponse> GetResourcesAsync(GetResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InitiateDocumentVersionUpload

        internal virtual InitiateDocumentVersionUploadResponse InitiateDocumentVersionUpload(InitiateDocumentVersionUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateDocumentVersionUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateDocumentVersionUploadResponseUnmarshaller.Instance;

            return Invoke<InitiateDocumentVersionUploadResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<InitiateDocumentVersionUploadResponse> InitiateDocumentVersionUploadAsync(InitiateDocumentVersionUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateDocumentVersionUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateDocumentVersionUploadResponseUnmarshaller.Instance;

            return InvokeAsync<InitiateDocumentVersionUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveAllResourcePermissions

        internal virtual RemoveAllResourcePermissionsResponse RemoveAllResourcePermissions(RemoveAllResourcePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAllResourcePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAllResourcePermissionsResponseUnmarshaller.Instance;

            return Invoke<RemoveAllResourcePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Removes all the permissions from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAllResourcePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RemoveAllResourcePermissionsResponse> RemoveAllResourcePermissionsAsync(RemoveAllResourcePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAllResourcePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAllResourcePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveAllResourcePermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveResourcePermission

        internal virtual RemoveResourcePermissionResponse RemoveResourcePermission(RemoveResourcePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveResourcePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveResourcePermissionResponseUnmarshaller.Instance;

            return Invoke<RemoveResourcePermissionResponse>(request, options);
        }



        /// <summary>
        /// Removes the permission for the specified principal from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveResourcePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RemoveResourcePermissionResponse> RemoveResourcePermissionAsync(RemoveResourcePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveResourcePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveResourcePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveResourcePermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDocument

        internal virtual UpdateDocumentResponse UpdateDocument(UpdateDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDocumentResponseUnmarshaller.Instance;

            return Invoke<UpdateDocumentResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified attributes of a document. The user must have access to both
        /// the document and its parent folder, if applicable.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDocument service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConcurrentModificationException">
        /// The resource hierarchy is changing.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ConflictingOperationException">
        /// Another operation is in progress on the resource that conflicts with the current operation.
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
        public virtual Task<UpdateDocumentResponse> UpdateDocumentAsync(UpdateDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDocumentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDocumentVersion

        internal virtual UpdateDocumentVersionResponse UpdateDocumentVersion(UpdateDocumentVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDocumentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDocumentVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateDocumentVersionResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateDocumentVersionResponse> UpdateDocumentVersionAsync(UpdateDocumentVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDocumentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDocumentVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDocumentVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFolder

        internal virtual UpdateFolderResponse UpdateFolder(UpdateFolderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFolderResponseUnmarshaller.Instance;

            return Invoke<UpdateFolderResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified attributes of the specified folder. The user must have access
        /// to both the folder and its parent folder, if applicable.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFolder service method, as returned by WorkDocs.</returns>
        /// <exception cref="Amazon.WorkDocs.Model.ConcurrentModificationException">
        /// The resource hierarchy is changing.
        /// </exception>
        /// <exception cref="Amazon.WorkDocs.Model.ConflictingOperationException">
        /// Another operation is in progress on the resource that conflicts with the current operation.
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
        public virtual Task<UpdateFolderResponse> UpdateFolderAsync(UpdateFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFolderResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFolderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateUser

        internal virtual UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return Invoke<UpdateUserResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified attributes of the specified user, and grants or revokes administrative
        /// privileges to the Amazon WorkDocs site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}