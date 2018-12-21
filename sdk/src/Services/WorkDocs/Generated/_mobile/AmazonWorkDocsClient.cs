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
    public partial class AmazonWorkDocsClient : AmazonServiceClient, IAmazonWorkDocs
    {
        private static IServiceMetadata serviceMetadata = new AmazonWorkDocsMetadata();
        
        #region Constructors

#if CORECLR
    
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

#endif

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
        /// Initiates the asynchronous execution of the GetResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}