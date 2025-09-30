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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.QApps.Model;
using Amazon.QApps.Model.Internal.MarshallTransformations;
using Amazon.QApps.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.QApps
{
    /// <summary>
    /// <para>Implementation for accessing QApps</para>
    ///
    /// The Amazon Q Apps feature capability within Amazon Q Business allows web experience
    /// users to create lightweight, purpose-built AI apps to fulfill specific tasks from
    /// within their web experience. For example, users can create a Q App that exclusively
    /// generates marketing-related content to improve your marketing team's productivity
    /// or a Q App for writing customer emails and creating promotional content using a certain
    /// style of voice, tone, and branding. For more information on the capabilities, see
    /// <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/deploy-experience-iam-role.html#q-apps-actions">Amazon
    /// Q Apps capabilities</a> in the <i>Amazon Q Business User Guide</i>. 
    /// 
    ///  
    /// <para>
    /// For an overview of the Amazon Q App APIs, see <a href="https://docs.aws.amazon.com/amazonq/latest/api-reference/API_Operations_QApps.html">Overview
    /// of Amazon Q Apps API operations</a>.
    /// </para>
    ///  
    /// <para>
    /// For information about the IAM access control permissions you need to use the Amazon
    /// Q Apps API, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/deploy-experience-iam-role.html">
    /// IAM role for the Amazon Q Business web experience including Amazon Q Apps</a> in the
    /// <i>Amazon Q Business User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonQAppsClient : AmazonServiceClient, IAmazonQApps
    {
        private static IServiceMetadata serviceMetadata = new AmazonQAppsMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonQAppsClient with the credentials loaded from the application's
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
        public AmazonQAppsClient()
            : base(new AmazonQAppsConfig()) { }

        /// <summary>
        /// Constructs AmazonQAppsClient with the credentials loaded from the application's
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
        public AmazonQAppsClient(RegionEndpoint region)
            : base(new AmazonQAppsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonQAppsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonQAppsClient Configuration Object</param>
        public AmazonQAppsClient(AmazonQAppsConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonQAppsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonQAppsClient(AWSCredentials credentials)
            : this(credentials, new AmazonQAppsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQAppsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQAppsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonQAppsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQAppsClient with AWS Credentials and an
        /// AmazonQAppsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonQAppsClient Configuration Object</param>
        public AmazonQAppsClient(AWSCredentials credentials, AmazonQAppsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQAppsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonQAppsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQAppsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQAppsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQAppsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQAppsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonQAppsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQAppsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonQAppsClient Configuration Object</param>
        public AmazonQAppsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonQAppsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQAppsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonQAppsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQAppsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQAppsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQAppsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQAppsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQAppsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQAppsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonQAppsClient Configuration Object</param>
        public AmazonQAppsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonQAppsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IQAppsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IQAppsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new QAppsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonQAppsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonQAppsAuthSchemeHandler());
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


        #region  AssociateLibraryItemReview

        internal virtual AssociateLibraryItemReviewResponse AssociateLibraryItemReview(AssociateLibraryItemReviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateLibraryItemReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateLibraryItemReviewResponseUnmarshaller.Instance;

            return Invoke<AssociateLibraryItemReviewResponse>(request, options);
        }



        /// <summary>
        /// Associates a rating or review for a library item with the user submitting the request.
        /// This increments the rating count for the specified library item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLibraryItemReview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateLibraryItemReview service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ConflictException">
        /// The requested operation could not be completed due to a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/AssociateLibraryItemReview">REST API Reference for AssociateLibraryItemReview Operation</seealso>
        public virtual Task<AssociateLibraryItemReviewResponse> AssociateLibraryItemReviewAsync(AssociateLibraryItemReviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateLibraryItemReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateLibraryItemReviewResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateLibraryItemReviewResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateQAppWithUser

        internal virtual AssociateQAppWithUserResponse AssociateQAppWithUser(AssociateQAppWithUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateQAppWithUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateQAppWithUserResponseUnmarshaller.Instance;

            return Invoke<AssociateQAppWithUserResponse>(request, options);
        }



        /// <summary>
        /// This operation creates a link between the user's identity calling the operation and
        /// a specific Q App. This is useful to mark the Q App as a <i>favorite</i> for the user
        /// if the user doesn't own the Amazon Q App so they can still run it and see it in their
        /// inventory of Q Apps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateQAppWithUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateQAppWithUser service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/AssociateQAppWithUser">REST API Reference for AssociateQAppWithUser Operation</seealso>
        public virtual Task<AssociateQAppWithUserResponse> AssociateQAppWithUserAsync(AssociateQAppWithUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateQAppWithUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateQAppWithUserResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateQAppWithUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchCreateCategory

        internal virtual BatchCreateCategoryResponse BatchCreateCategory(BatchCreateCategoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateCategoryResponseUnmarshaller.Instance;

            return Invoke<BatchCreateCategoryResponse>(request, options);
        }



        /// <summary>
        /// Creates Categories for the Amazon Q Business application environment instance. Web
        /// experience users use Categories to tag and filter library items. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/qapps-custom-labels.html">Custom
        /// labels for Amazon Q Apps</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateCategory service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ConflictException">
        /// The requested operation could not be completed due to a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/BatchCreateCategory">REST API Reference for BatchCreateCategory Operation</seealso>
        public virtual Task<BatchCreateCategoryResponse> BatchCreateCategoryAsync(BatchCreateCategoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateCategoryResponseUnmarshaller.Instance;

            return InvokeAsync<BatchCreateCategoryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDeleteCategory

        internal virtual BatchDeleteCategoryResponse BatchDeleteCategory(BatchDeleteCategoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteCategoryResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteCategoryResponse>(request, options);
        }



        /// <summary>
        /// Deletes Categories for the Amazon Q Business application environment instance. Web
        /// experience users use Categories to tag and filter library items. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/qapps-custom-labels.html">Custom
        /// labels for Amazon Q Apps</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteCategory service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ConflictException">
        /// The requested operation could not be completed due to a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/BatchDeleteCategory">REST API Reference for BatchDeleteCategory Operation</seealso>
        public virtual Task<BatchDeleteCategoryResponse> BatchDeleteCategoryAsync(BatchDeleteCategoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteCategoryResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteCategoryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchUpdateCategory

        internal virtual BatchUpdateCategoryResponse BatchUpdateCategory(BatchUpdateCategoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateCategoryResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateCategoryResponse>(request, options);
        }



        /// <summary>
        /// Updates Categories for the Amazon Q Business application environment instance. Web
        /// experience users use Categories to tag and filter library items. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/qapps-custom-labels.html">Custom
        /// labels for Amazon Q Apps</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateCategory service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ConflictException">
        /// The requested operation could not be completed due to a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/BatchUpdateCategory">REST API Reference for BatchUpdateCategory Operation</seealso>
        public virtual Task<BatchUpdateCategoryResponse> BatchUpdateCategoryAsync(BatchUpdateCategoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateCategoryResponseUnmarshaller.Instance;

            return InvokeAsync<BatchUpdateCategoryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateLibraryItem

        internal virtual CreateLibraryItemResponse CreateLibraryItem(CreateLibraryItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLibraryItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLibraryItemResponseUnmarshaller.Instance;

            return Invoke<CreateLibraryItemResponse>(request, options);
        }



        /// <summary>
        /// Creates a new library item for an Amazon Q App, allowing it to be discovered and used
        /// by other allowed users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLibraryItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLibraryItem service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/CreateLibraryItem">REST API Reference for CreateLibraryItem Operation</seealso>
        public virtual Task<CreateLibraryItemResponse> CreateLibraryItemAsync(CreateLibraryItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLibraryItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLibraryItemResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLibraryItemResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePresignedUrl

        internal virtual CreatePresignedUrlResponse CreatePresignedUrl(CreatePresignedUrlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePresignedUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresignedUrlResponseUnmarshaller.Instance;

            return Invoke<CreatePresignedUrlResponse>(request, options);
        }



        /// <summary>
        /// Creates a presigned URL for an S3 POST operation to upload a file. You can use this
        /// URL to set a default file for a <c>FileUploadCard</c> in a Q App definition or to
        /// provide a file for a single Q App run. The <c>scope</c> parameter determines how the
        /// file will be used, either at the app definition level or the app session level.
        /// 
        ///  <note> 
        /// <para>
        /// The IAM permissions are derived from the <c>qapps:ImportDocument</c> action. For more
        /// information on the IAM policy for Amazon Q Apps, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/deploy-q-apps-iam-permissions.html">IAM
        /// permissions for using Amazon Q Apps</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePresignedUrl service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/CreatePresignedUrl">REST API Reference for CreatePresignedUrl Operation</seealso>
        public virtual Task<CreatePresignedUrlResponse> CreatePresignedUrlAsync(CreatePresignedUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePresignedUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresignedUrlResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePresignedUrlResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateQApp

        internal virtual CreateQAppResponse CreateQApp(CreateQAppRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQAppResponseUnmarshaller.Instance;

            return Invoke<CreateQAppResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Amazon Q App based on the provided definition. The Q App definition
        /// specifies the cards and flow of the Q App. This operation also calculates the dependencies
        /// between the cards by inspecting the references in the prompts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQApp service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ConflictException">
        /// The requested operation could not be completed due to a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ContentTooLargeException">
        /// The requested operation could not be completed because the content exceeds the maximum
        /// allowed size.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/CreateQApp">REST API Reference for CreateQApp Operation</seealso>
        public virtual Task<CreateQAppResponse> CreateQAppAsync(CreateQAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQAppResponseUnmarshaller.Instance;

            return InvokeAsync<CreateQAppResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteLibraryItem

        internal virtual DeleteLibraryItemResponse DeleteLibraryItem(DeleteLibraryItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLibraryItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLibraryItemResponseUnmarshaller.Instance;

            return Invoke<DeleteLibraryItemResponse>(request, options);
        }



        /// <summary>
        /// Deletes a library item for an Amazon Q App, removing it from the library so it can
        /// no longer be discovered or used by other users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLibraryItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLibraryItem service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DeleteLibraryItem">REST API Reference for DeleteLibraryItem Operation</seealso>
        public virtual Task<DeleteLibraryItemResponse> DeleteLibraryItemAsync(DeleteLibraryItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLibraryItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLibraryItemResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLibraryItemResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteQApp

        internal virtual DeleteQAppResponse DeleteQApp(DeleteQAppRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQAppResponseUnmarshaller.Instance;

            return Invoke<DeleteQAppResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Q App owned by the user. If the Q App was previously published to
        /// the library, it is also removed from the library.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQApp service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DeleteQApp">REST API Reference for DeleteQApp Operation</seealso>
        public virtual Task<DeleteQAppResponse> DeleteQAppAsync(DeleteQAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQAppResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteQAppResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeQAppPermissions

        internal virtual DescribeQAppPermissionsResponse DescribeQAppPermissions(DescribeQAppPermissionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeQAppPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQAppPermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeQAppPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Describes read permissions for a Amazon Q App in Amazon Q Business application environment
        /// instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQAppPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeQAppPermissions service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DescribeQAppPermissions">REST API Reference for DescribeQAppPermissions Operation</seealso>
        public virtual Task<DescribeQAppPermissionsResponse> DescribeQAppPermissionsAsync(DescribeQAppPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeQAppPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQAppPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeQAppPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateLibraryItemReview

        internal virtual DisassociateLibraryItemReviewResponse DisassociateLibraryItemReview(DisassociateLibraryItemReviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateLibraryItemReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateLibraryItemReviewResponseUnmarshaller.Instance;

            return Invoke<DisassociateLibraryItemReviewResponse>(request, options);
        }



        /// <summary>
        /// Removes a rating or review previously submitted by the user for a library item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLibraryItemReview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateLibraryItemReview service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ConflictException">
        /// The requested operation could not be completed due to a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DisassociateLibraryItemReview">REST API Reference for DisassociateLibraryItemReview Operation</seealso>
        public virtual Task<DisassociateLibraryItemReviewResponse> DisassociateLibraryItemReviewAsync(DisassociateLibraryItemReviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateLibraryItemReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateLibraryItemReviewResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateLibraryItemReviewResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateQAppFromUser

        internal virtual DisassociateQAppFromUserResponse DisassociateQAppFromUser(DisassociateQAppFromUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateQAppFromUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateQAppFromUserResponseUnmarshaller.Instance;

            return Invoke<DisassociateQAppFromUserResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a Q App from a user removing the user's access to run the Q App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateQAppFromUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateQAppFromUser service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DisassociateQAppFromUser">REST API Reference for DisassociateQAppFromUser Operation</seealso>
        public virtual Task<DisassociateQAppFromUserResponse> DisassociateQAppFromUserAsync(DisassociateQAppFromUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateQAppFromUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateQAppFromUserResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateQAppFromUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExportQAppSessionData

        internal virtual ExportQAppSessionDataResponse ExportQAppSessionData(ExportQAppSessionDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportQAppSessionDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportQAppSessionDataResponseUnmarshaller.Instance;

            return Invoke<ExportQAppSessionDataResponse>(request, options);
        }



        /// <summary>
        /// Exports the collected data of a Q App data collection session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportQAppSessionData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportQAppSessionData service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ConflictException">
        /// The requested operation could not be completed due to a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ExportQAppSessionData">REST API Reference for ExportQAppSessionData Operation</seealso>
        public virtual Task<ExportQAppSessionDataResponse> ExportQAppSessionDataAsync(ExportQAppSessionDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportQAppSessionDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportQAppSessionDataResponseUnmarshaller.Instance;

            return InvokeAsync<ExportQAppSessionDataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetLibraryItem

        internal virtual GetLibraryItemResponse GetLibraryItem(GetLibraryItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLibraryItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLibraryItemResponseUnmarshaller.Instance;

            return Invoke<GetLibraryItemResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details about a library item for an Amazon Q App, including its metadata,
        /// categories, ratings, and usage statistics.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLibraryItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLibraryItem service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetLibraryItem">REST API Reference for GetLibraryItem Operation</seealso>
        public virtual Task<GetLibraryItemResponse> GetLibraryItemAsync(GetLibraryItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLibraryItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLibraryItemResponseUnmarshaller.Instance;

            return InvokeAsync<GetLibraryItemResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetQApp

        internal virtual GetQAppResponse GetQApp(GetQAppRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQAppResponseUnmarshaller.Instance;

            return Invoke<GetQAppResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the full details of an Q App, including its definition specifying the cards
        /// and flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQApp service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetQApp">REST API Reference for GetQApp Operation</seealso>
        public virtual Task<GetQAppResponse> GetQAppAsync(GetQAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQAppResponseUnmarshaller.Instance;

            return InvokeAsync<GetQAppResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetQAppSession

        internal virtual GetQAppSessionResponse GetQAppSession(GetQAppSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQAppSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQAppSessionResponseUnmarshaller.Instance;

            return Invoke<GetQAppSessionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the current state and results for an active session of an Amazon Q App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQAppSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQAppSession service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetQAppSession">REST API Reference for GetQAppSession Operation</seealso>
        public virtual Task<GetQAppSessionResponse> GetQAppSessionAsync(GetQAppSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQAppSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQAppSessionResponseUnmarshaller.Instance;

            return InvokeAsync<GetQAppSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetQAppSessionMetadata

        internal virtual GetQAppSessionMetadataResponse GetQAppSessionMetadata(GetQAppSessionMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQAppSessionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQAppSessionMetadataResponseUnmarshaller.Instance;

            return Invoke<GetQAppSessionMetadataResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the current configuration of a Q App session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQAppSessionMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQAppSessionMetadata service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetQAppSessionMetadata">REST API Reference for GetQAppSessionMetadata Operation</seealso>
        public virtual Task<GetQAppSessionMetadataResponse> GetQAppSessionMetadataAsync(GetQAppSessionMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQAppSessionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQAppSessionMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<GetQAppSessionMetadataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ImportDocument

        internal virtual ImportDocumentResponse ImportDocument(ImportDocumentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportDocumentResponseUnmarshaller.Instance;

            return Invoke<ImportDocumentResponse>(request, options);
        }



        /// <summary>
        /// Uploads a file that can then be used either as a default in a <c>FileUploadCard</c>
        /// from Q App definition or as a file that is used inside a single Q App run. The purpose
        /// of the document is determined by a scope parameter that indicates whether it is at
        /// the app definition level or at the app session level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportDocument service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ContentTooLargeException">
        /// The requested operation could not be completed because the content exceeds the maximum
        /// allowed size.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ImportDocument">REST API Reference for ImportDocument Operation</seealso>
        public virtual Task<ImportDocumentResponse> ImportDocumentAsync(ImportDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<ImportDocumentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCategories

        internal virtual ListCategoriesResponse ListCategories(ListCategoriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCategoriesResponseUnmarshaller.Instance;

            return Invoke<ListCategoriesResponse>(request, options);
        }



        /// <summary>
        /// Lists the categories of a Amazon Q Business application environment instance. For
        /// more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/qapps-custom-labels.html">Custom
        /// labels for Amazon Q Apps</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCategories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCategories service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListCategories">REST API Reference for ListCategories Operation</seealso>
        public virtual Task<ListCategoriesResponse> ListCategoriesAsync(ListCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCategoriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCategoriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListLibraryItems

        internal virtual ListLibraryItemsResponse ListLibraryItems(ListLibraryItemsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLibraryItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLibraryItemsResponseUnmarshaller.Instance;

            return Invoke<ListLibraryItemsResponse>(request, options);
        }



        /// <summary>
        /// Lists the library items for Amazon Q Apps that are published and available for users
        /// in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLibraryItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLibraryItems service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListLibraryItems">REST API Reference for ListLibraryItems Operation</seealso>
        public virtual Task<ListLibraryItemsResponse> ListLibraryItemsAsync(ListLibraryItemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLibraryItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLibraryItemsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLibraryItemsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListQApps

        internal virtual ListQAppsResponse ListQApps(ListQAppsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQAppsResponseUnmarshaller.Instance;

            return Invoke<ListQAppsResponse>(request, options);
        }



        /// <summary>
        /// Lists the Amazon Q Apps owned by or associated with the user either because they created
        /// it or because they used it from the library in the past. The user identity is extracted
        /// from the credentials used to invoke this operation..
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQApps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQApps service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListQApps">REST API Reference for ListQApps Operation</seealso>
        public virtual Task<ListQAppsResponse> ListQAppsAsync(ListQAppsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQAppsResponseUnmarshaller.Instance;

            return InvokeAsync<ListQAppsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListQAppSessionData

        internal virtual ListQAppSessionDataResponse ListQAppSessionData(ListQAppSessionDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQAppSessionDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQAppSessionDataResponseUnmarshaller.Instance;

            return Invoke<ListQAppSessionDataResponse>(request, options);
        }



        /// <summary>
        /// Lists the collected data of a Q App data collection session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQAppSessionData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQAppSessionData service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListQAppSessionData">REST API Reference for ListQAppSessionData Operation</seealso>
        public virtual Task<ListQAppSessionDataResponse> ListQAppSessionDataAsync(ListQAppSessionDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQAppSessionDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQAppSessionDataResponseUnmarshaller.Instance;

            return InvokeAsync<ListQAppSessionDataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags associated with an Amazon Q Apps resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PredictQApp

        internal virtual PredictQAppResponse PredictQApp(PredictQAppRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PredictQAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PredictQAppResponseUnmarshaller.Instance;

            return Invoke<PredictQAppResponse>(request, options);
        }



        /// <summary>
        /// Generates an Amazon Q App definition based on either a conversation or a problem statement
        /// provided as input.The resulting app definition can be used to call <c>CreateQApp</c>.
        /// This API doesn't create Amazon Q Apps directly.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PredictQApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PredictQApp service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/PredictQApp">REST API Reference for PredictQApp Operation</seealso>
        public virtual Task<PredictQAppResponse> PredictQAppAsync(PredictQAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PredictQAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PredictQAppResponseUnmarshaller.Instance;

            return InvokeAsync<PredictQAppResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartQAppSession

        internal virtual StartQAppSessionResponse StartQAppSession(StartQAppSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQAppSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQAppSessionResponseUnmarshaller.Instance;

            return Invoke<StartQAppSessionResponse>(request, options);
        }



        /// <summary>
        /// Starts a new session for an Amazon Q App, allowing inputs to be provided and the app
        /// to be run.
        /// 
        ///  <note> 
        /// <para>
        /// Each Q App session will be condensed into a single conversation in the web experience.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQAppSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartQAppSession service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/StartQAppSession">REST API Reference for StartQAppSession Operation</seealso>
        public virtual Task<StartQAppSessionResponse> StartQAppSessionAsync(StartQAppSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQAppSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQAppSessionResponseUnmarshaller.Instance;

            return InvokeAsync<StartQAppSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopQAppSession

        internal virtual StopQAppSessionResponse StopQAppSession(StopQAppSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopQAppSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQAppSessionResponseUnmarshaller.Instance;

            return Invoke<StopQAppSessionResponse>(request, options);
        }



        /// <summary>
        /// Stops an active session for an Amazon Q App.This deletes all data related to the session
        /// and makes it invalid for future uses. The results of the session will be persisted
        /// as part of the conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopQAppSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopQAppSession service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/StopQAppSession">REST API Reference for StopQAppSession Operation</seealso>
        public virtual Task<StopQAppSessionResponse> StopQAppSessionAsync(StopQAppSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopQAppSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQAppSessionResponseUnmarshaller.Instance;

            return InvokeAsync<StopQAppSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Associates tags with an Amazon Q Apps resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ConflictException">
        /// The requested operation could not be completed due to a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Disassociates tags from an Amazon Q Apps resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateLibraryItem

        internal virtual UpdateLibraryItemResponse UpdateLibraryItem(UpdateLibraryItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLibraryItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLibraryItemResponseUnmarshaller.Instance;

            return Invoke<UpdateLibraryItemResponse>(request, options);
        }



        /// <summary>
        /// Updates the library item for an Amazon Q App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLibraryItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLibraryItem service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ConflictException">
        /// The requested operation could not be completed due to a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateLibraryItem">REST API Reference for UpdateLibraryItem Operation</seealso>
        public virtual Task<UpdateLibraryItemResponse> UpdateLibraryItemAsync(UpdateLibraryItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLibraryItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLibraryItemResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLibraryItemResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateLibraryItemMetadata

        internal virtual UpdateLibraryItemMetadataResponse UpdateLibraryItemMetadata(UpdateLibraryItemMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLibraryItemMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLibraryItemMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateLibraryItemMetadataResponse>(request, options);
        }



        /// <summary>
        /// Updates the verification status of a library item for an Amazon Q App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLibraryItemMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLibraryItemMetadata service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ConflictException">
        /// The requested operation could not be completed due to a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateLibraryItemMetadata">REST API Reference for UpdateLibraryItemMetadata Operation</seealso>
        public virtual Task<UpdateLibraryItemMetadataResponse> UpdateLibraryItemMetadataAsync(UpdateLibraryItemMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLibraryItemMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLibraryItemMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLibraryItemMetadataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateQApp

        internal virtual UpdateQAppResponse UpdateQApp(UpdateQAppRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQAppResponseUnmarshaller.Instance;

            return Invoke<UpdateQAppResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing Amazon Q App, allowing modifications to its title, description,
        /// and definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQApp service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ContentTooLargeException">
        /// The requested operation could not be completed because the content exceeds the maximum
        /// allowed size.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQApp">REST API Reference for UpdateQApp Operation</seealso>
        public virtual Task<UpdateQAppResponse> UpdateQAppAsync(UpdateQAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQAppResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateQAppResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateQAppPermissions

        internal virtual UpdateQAppPermissionsResponse UpdateQAppPermissions(UpdateQAppPermissionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQAppPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQAppPermissionsResponseUnmarshaller.Instance;

            return Invoke<UpdateQAppPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Updates read permissions for a Amazon Q App in Amazon Q Business application environment
        /// instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQAppPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQAppPermissions service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQAppPermissions">REST API Reference for UpdateQAppPermissions Operation</seealso>
        public virtual Task<UpdateQAppPermissionsResponse> UpdateQAppPermissionsAsync(UpdateQAppPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQAppPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQAppPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateQAppPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateQAppSession

        internal virtual UpdateQAppSessionResponse UpdateQAppSession(UpdateQAppSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQAppSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQAppSessionResponseUnmarshaller.Instance;

            return Invoke<UpdateQAppSessionResponse>(request, options);
        }



        /// <summary>
        /// Updates the session for a given Q App <c>sessionId</c>. This is only valid when at
        /// least one card of the session is in the <c>WAITING</c> state. Data for each <c>WAITING</c>
        /// card can be provided as input. If inputs are not provided, the call will be accepted
        /// but session will not move forward. Inputs for cards that are not in the <c>WAITING</c>
        /// status will be ignored.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQAppSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQAppSession service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQAppSession">REST API Reference for UpdateQAppSession Operation</seealso>
        public virtual Task<UpdateQAppSessionResponse> UpdateQAppSessionAsync(UpdateQAppSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQAppSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQAppSessionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateQAppSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateQAppSessionMetadata

        internal virtual UpdateQAppSessionMetadataResponse UpdateQAppSessionMetadata(UpdateQAppSessionMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQAppSessionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQAppSessionMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateQAppSessionMetadataResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration metadata of a session for a given Q App <c>sessionId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQAppSessionMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQAppSessionMetadata service method, as returned by QApps.</returns>
        /// <exception cref="Amazon.QApps.Model.AccessDeniedException">
        /// The client is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.InternalServerException">
        /// An internal service error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ServiceQuotaExceededException">
        /// The requested operation could not be completed because it would exceed the service's
        /// quota or limit.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ThrottlingException">
        /// The requested operation could not be completed because too many requests were sent
        /// at once. Wait a bit and try again later.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.UnauthorizedException">
        /// The client is not authenticated or authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.QApps.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQAppSessionMetadata">REST API Reference for UpdateQAppSessionMetadata Operation</seealso>
        public virtual Task<UpdateQAppSessionMetadataResponse> UpdateQAppSessionMetadataAsync(UpdateQAppSessionMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQAppSessionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQAppSessionMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateQAppSessionMetadataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}