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
using System.Collections.Generic;
using System.Net;

using Amazon.QApps.Model;
using Amazon.QApps.Model.Internal.MarshallTransformations;
using Amazon.QApps.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQAppsConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQAppsConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonQAppsEndpointResolver());
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

        /// <summary>
        /// Associates a rating or review for a library item with the user submitting the request.
        /// This increments the rating count for the specified library item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLibraryItemReview service method.</param>
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
        public virtual AssociateLibraryItemReviewResponse AssociateLibraryItemReview(AssociateLibraryItemReviewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateLibraryItemReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateLibraryItemReviewResponseUnmarshaller.Instance;

            return Invoke<AssociateLibraryItemReviewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateLibraryItemReview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateLibraryItemReview operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateLibraryItemReview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/AssociateLibraryItemReview">REST API Reference for AssociateLibraryItemReview Operation</seealso>
        public virtual IAsyncResult BeginAssociateLibraryItemReview(AssociateLibraryItemReviewRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateLibraryItemReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateLibraryItemReviewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateLibraryItemReview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateLibraryItemReview.</param>
        /// 
        /// <returns>Returns a  AssociateLibraryItemReviewResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/AssociateLibraryItemReview">REST API Reference for AssociateLibraryItemReview Operation</seealso>
        public virtual AssociateLibraryItemReviewResponse EndAssociateLibraryItemReview(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateLibraryItemReviewResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateQAppWithUser

        /// <summary>
        /// This operation creates a link between the user's identity calling the operation and
        /// a specific Q App. This is useful to mark the Q App as a <i>favorite</i> for the user
        /// if the user doesn't own the Amazon Q App so they can still run it and see it in their
        /// inventory of Q Apps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateQAppWithUser service method.</param>
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
        public virtual AssociateQAppWithUserResponse AssociateQAppWithUser(AssociateQAppWithUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateQAppWithUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateQAppWithUserResponseUnmarshaller.Instance;

            return Invoke<AssociateQAppWithUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateQAppWithUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateQAppWithUser operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateQAppWithUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/AssociateQAppWithUser">REST API Reference for AssociateQAppWithUser Operation</seealso>
        public virtual IAsyncResult BeginAssociateQAppWithUser(AssociateQAppWithUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateQAppWithUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateQAppWithUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateQAppWithUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateQAppWithUser.</param>
        /// 
        /// <returns>Returns a  AssociateQAppWithUserResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/AssociateQAppWithUser">REST API Reference for AssociateQAppWithUser Operation</seealso>
        public virtual AssociateQAppWithUserResponse EndAssociateQAppWithUser(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateQAppWithUserResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchCreateCategory

        /// <summary>
        /// Creates Categories for the Amazon Q Business application environment instance. Web
        /// experience users use Categories to tag and filter library items. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/qapps-custom-labels.html">Custom
        /// labels for Amazon Q Apps</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateCategory service method.</param>
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
        public virtual BatchCreateCategoryResponse BatchCreateCategory(BatchCreateCategoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateCategoryResponseUnmarshaller.Instance;

            return Invoke<BatchCreateCategoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateCategory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateCategory operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateCategory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/BatchCreateCategory">REST API Reference for BatchCreateCategory Operation</seealso>
        public virtual IAsyncResult BeginBatchCreateCategory(BatchCreateCategoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateCategoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateCategory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateCategory.</param>
        /// 
        /// <returns>Returns a  BatchCreateCategoryResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/BatchCreateCategory">REST API Reference for BatchCreateCategory Operation</seealso>
        public virtual BatchCreateCategoryResponse EndBatchCreateCategory(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchCreateCategoryResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeleteCategory

        /// <summary>
        /// Deletes Categories for the Amazon Q Business application environment instance. Web
        /// experience users use Categories to tag and filter library items. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/qapps-custom-labels.html">Custom
        /// labels for Amazon Q Apps</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteCategory service method.</param>
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
        public virtual BatchDeleteCategoryResponse BatchDeleteCategory(BatchDeleteCategoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteCategoryResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteCategoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteCategory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteCategory operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteCategory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/BatchDeleteCategory">REST API Reference for BatchDeleteCategory Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteCategory(BatchDeleteCategoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteCategoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteCategory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteCategory.</param>
        /// 
        /// <returns>Returns a  BatchDeleteCategoryResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/BatchDeleteCategory">REST API Reference for BatchDeleteCategory Operation</seealso>
        public virtual BatchDeleteCategoryResponse EndBatchDeleteCategory(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteCategoryResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchUpdateCategory

        /// <summary>
        /// Updates Categories for the Amazon Q Business application environment instance. Web
        /// experience users use Categories to tag and filter library items. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/qapps-custom-labels.html">Custom
        /// labels for Amazon Q Apps</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateCategory service method.</param>
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
        public virtual BatchUpdateCategoryResponse BatchUpdateCategory(BatchUpdateCategoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateCategoryResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateCategoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateCategory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateCategory operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateCategory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/BatchUpdateCategory">REST API Reference for BatchUpdateCategory Operation</seealso>
        public virtual IAsyncResult BeginBatchUpdateCategory(BatchUpdateCategoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateCategoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateCategory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateCategory.</param>
        /// 
        /// <returns>Returns a  BatchUpdateCategoryResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/BatchUpdateCategory">REST API Reference for BatchUpdateCategory Operation</seealso>
        public virtual BatchUpdateCategoryResponse EndBatchUpdateCategory(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUpdateCategoryResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLibraryItem

        /// <summary>
        /// Creates a new library item for an Amazon Q App, allowing it to be discovered and used
        /// by other allowed users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLibraryItem service method.</param>
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
        public virtual CreateLibraryItemResponse CreateLibraryItem(CreateLibraryItemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLibraryItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLibraryItemResponseUnmarshaller.Instance;

            return Invoke<CreateLibraryItemResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLibraryItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLibraryItem operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLibraryItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/CreateLibraryItem">REST API Reference for CreateLibraryItem Operation</seealso>
        public virtual IAsyncResult BeginCreateLibraryItem(CreateLibraryItemRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLibraryItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLibraryItemResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLibraryItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLibraryItem.</param>
        /// 
        /// <returns>Returns a  CreateLibraryItemResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/CreateLibraryItem">REST API Reference for CreateLibraryItem Operation</seealso>
        public virtual CreateLibraryItemResponse EndCreateLibraryItem(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLibraryItemResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePresignedUrl

        /// <summary>
        /// Creates a presigned URL for an S3 POST operation to upload a file. You can use this
        /// URL to set a default file for a <c>FileUploadCard</c> in a Q App definition or to
        /// provide a file for a single Q App run. The <c>scope</c> parameter determines how the
        /// file will be used, either at the app definition level or the app session level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedUrl service method.</param>
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
        public virtual CreatePresignedUrlResponse CreatePresignedUrl(CreatePresignedUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePresignedUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresignedUrlResponseUnmarshaller.Instance;

            return Invoke<CreatePresignedUrlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePresignedUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedUrl operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePresignedUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/CreatePresignedUrl">REST API Reference for CreatePresignedUrl Operation</seealso>
        public virtual IAsyncResult BeginCreatePresignedUrl(CreatePresignedUrlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePresignedUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresignedUrlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePresignedUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePresignedUrl.</param>
        /// 
        /// <returns>Returns a  CreatePresignedUrlResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/CreatePresignedUrl">REST API Reference for CreatePresignedUrl Operation</seealso>
        public virtual CreatePresignedUrlResponse EndCreatePresignedUrl(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePresignedUrlResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateQApp

        /// <summary>
        /// Creates a new Amazon Q App based on the provided definition. The Q App definition
        /// specifies the cards and flow of the Q App. This operation also calculates the dependencies
        /// between the cards by inspecting the references in the prompts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQApp service method.</param>
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
        public virtual CreateQAppResponse CreateQApp(CreateQAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQAppResponseUnmarshaller.Instance;

            return Invoke<CreateQAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateQApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQApp operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateQApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/CreateQApp">REST API Reference for CreateQApp Operation</seealso>
        public virtual IAsyncResult BeginCreateQApp(CreateQAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateQApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateQApp.</param>
        /// 
        /// <returns>Returns a  CreateQAppResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/CreateQApp">REST API Reference for CreateQApp Operation</seealso>
        public virtual CreateQAppResponse EndCreateQApp(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateQAppResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLibraryItem

        /// <summary>
        /// Deletes a library item for an Amazon Q App, removing it from the library so it can
        /// no longer be discovered or used by other users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLibraryItem service method.</param>
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
        public virtual DeleteLibraryItemResponse DeleteLibraryItem(DeleteLibraryItemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLibraryItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLibraryItemResponseUnmarshaller.Instance;

            return Invoke<DeleteLibraryItemResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLibraryItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLibraryItem operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLibraryItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DeleteLibraryItem">REST API Reference for DeleteLibraryItem Operation</seealso>
        public virtual IAsyncResult BeginDeleteLibraryItem(DeleteLibraryItemRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLibraryItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLibraryItemResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLibraryItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLibraryItem.</param>
        /// 
        /// <returns>Returns a  DeleteLibraryItemResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DeleteLibraryItem">REST API Reference for DeleteLibraryItem Operation</seealso>
        public virtual DeleteLibraryItemResponse EndDeleteLibraryItem(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLibraryItemResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteQApp

        /// <summary>
        /// Deletes an Amazon Q App owned by the user. If the Q App was previously published to
        /// the library, it is also removed from the library.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQApp service method.</param>
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
        public virtual DeleteQAppResponse DeleteQApp(DeleteQAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQAppResponseUnmarshaller.Instance;

            return Invoke<DeleteQAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQApp operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DeleteQApp">REST API Reference for DeleteQApp Operation</seealso>
        public virtual IAsyncResult BeginDeleteQApp(DeleteQAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQApp.</param>
        /// 
        /// <returns>Returns a  DeleteQAppResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DeleteQApp">REST API Reference for DeleteQApp Operation</seealso>
        public virtual DeleteQAppResponse EndDeleteQApp(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteQAppResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeQAppPermissions

        /// <summary>
        /// Describes read permissions for a Amazon Q App in Amazon Q Business application environment
        /// instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQAppPermissions service method.</param>
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
        public virtual DescribeQAppPermissionsResponse DescribeQAppPermissions(DescribeQAppPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQAppPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQAppPermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeQAppPermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeQAppPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeQAppPermissions operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeQAppPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DescribeQAppPermissions">REST API Reference for DescribeQAppPermissions Operation</seealso>
        public virtual IAsyncResult BeginDescribeQAppPermissions(DescribeQAppPermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQAppPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQAppPermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeQAppPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeQAppPermissions.</param>
        /// 
        /// <returns>Returns a  DescribeQAppPermissionsResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DescribeQAppPermissions">REST API Reference for DescribeQAppPermissions Operation</seealso>
        public virtual DescribeQAppPermissionsResponse EndDescribeQAppPermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeQAppPermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateLibraryItemReview

        /// <summary>
        /// Removes a rating or review previously submitted by the user for a library item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLibraryItemReview service method.</param>
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
        public virtual DisassociateLibraryItemReviewResponse DisassociateLibraryItemReview(DisassociateLibraryItemReviewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateLibraryItemReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateLibraryItemReviewResponseUnmarshaller.Instance;

            return Invoke<DisassociateLibraryItemReviewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateLibraryItemReview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLibraryItemReview operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateLibraryItemReview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DisassociateLibraryItemReview">REST API Reference for DisassociateLibraryItemReview Operation</seealso>
        public virtual IAsyncResult BeginDisassociateLibraryItemReview(DisassociateLibraryItemReviewRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateLibraryItemReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateLibraryItemReviewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateLibraryItemReview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateLibraryItemReview.</param>
        /// 
        /// <returns>Returns a  DisassociateLibraryItemReviewResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DisassociateLibraryItemReview">REST API Reference for DisassociateLibraryItemReview Operation</seealso>
        public virtual DisassociateLibraryItemReviewResponse EndDisassociateLibraryItemReview(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateLibraryItemReviewResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateQAppFromUser

        /// <summary>
        /// Disassociates a Q App from a user removing the user's access to run the Q App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateQAppFromUser service method.</param>
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
        public virtual DisassociateQAppFromUserResponse DisassociateQAppFromUser(DisassociateQAppFromUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateQAppFromUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateQAppFromUserResponseUnmarshaller.Instance;

            return Invoke<DisassociateQAppFromUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateQAppFromUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateQAppFromUser operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateQAppFromUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DisassociateQAppFromUser">REST API Reference for DisassociateQAppFromUser Operation</seealso>
        public virtual IAsyncResult BeginDisassociateQAppFromUser(DisassociateQAppFromUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateQAppFromUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateQAppFromUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateQAppFromUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateQAppFromUser.</param>
        /// 
        /// <returns>Returns a  DisassociateQAppFromUserResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/DisassociateQAppFromUser">REST API Reference for DisassociateQAppFromUser Operation</seealso>
        public virtual DisassociateQAppFromUserResponse EndDisassociateQAppFromUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateQAppFromUserResponse>(asyncResult);
        }

        #endregion
        
        #region  ExportQAppSessionData

        /// <summary>
        /// Exports the collected data of a Q App data collection session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportQAppSessionData service method.</param>
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
        public virtual ExportQAppSessionDataResponse ExportQAppSessionData(ExportQAppSessionDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportQAppSessionDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportQAppSessionDataResponseUnmarshaller.Instance;

            return Invoke<ExportQAppSessionDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportQAppSessionData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportQAppSessionData operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportQAppSessionData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ExportQAppSessionData">REST API Reference for ExportQAppSessionData Operation</seealso>
        public virtual IAsyncResult BeginExportQAppSessionData(ExportQAppSessionDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportQAppSessionDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportQAppSessionDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportQAppSessionData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportQAppSessionData.</param>
        /// 
        /// <returns>Returns a  ExportQAppSessionDataResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ExportQAppSessionData">REST API Reference for ExportQAppSessionData Operation</seealso>
        public virtual ExportQAppSessionDataResponse EndExportQAppSessionData(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportQAppSessionDataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLibraryItem

        /// <summary>
        /// Retrieves details about a library item for an Amazon Q App, including its metadata,
        /// categories, ratings, and usage statistics.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLibraryItem service method.</param>
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
        public virtual GetLibraryItemResponse GetLibraryItem(GetLibraryItemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLibraryItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLibraryItemResponseUnmarshaller.Instance;

            return Invoke<GetLibraryItemResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLibraryItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLibraryItem operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLibraryItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetLibraryItem">REST API Reference for GetLibraryItem Operation</seealso>
        public virtual IAsyncResult BeginGetLibraryItem(GetLibraryItemRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLibraryItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLibraryItemResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLibraryItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLibraryItem.</param>
        /// 
        /// <returns>Returns a  GetLibraryItemResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetLibraryItem">REST API Reference for GetLibraryItem Operation</seealso>
        public virtual GetLibraryItemResponse EndGetLibraryItem(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLibraryItemResponse>(asyncResult);
        }

        #endregion
        
        #region  GetQApp

        /// <summary>
        /// Retrieves the full details of an Q App, including its definition specifying the cards
        /// and flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQApp service method.</param>
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
        public virtual GetQAppResponse GetQApp(GetQAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQAppResponseUnmarshaller.Instance;

            return Invoke<GetQAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetQApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQApp operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetQApp">REST API Reference for GetQApp Operation</seealso>
        public virtual IAsyncResult BeginGetQApp(GetQAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetQApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQApp.</param>
        /// 
        /// <returns>Returns a  GetQAppResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetQApp">REST API Reference for GetQApp Operation</seealso>
        public virtual GetQAppResponse EndGetQApp(IAsyncResult asyncResult)
        {
            return EndInvoke<GetQAppResponse>(asyncResult);
        }

        #endregion
        
        #region  GetQAppSession

        /// <summary>
        /// Retrieves the current state and results for an active session of an Amazon Q App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQAppSession service method.</param>
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
        public virtual GetQAppSessionResponse GetQAppSession(GetQAppSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQAppSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQAppSessionResponseUnmarshaller.Instance;

            return Invoke<GetQAppSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetQAppSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQAppSession operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQAppSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetQAppSession">REST API Reference for GetQAppSession Operation</seealso>
        public virtual IAsyncResult BeginGetQAppSession(GetQAppSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQAppSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQAppSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetQAppSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQAppSession.</param>
        /// 
        /// <returns>Returns a  GetQAppSessionResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetQAppSession">REST API Reference for GetQAppSession Operation</seealso>
        public virtual GetQAppSessionResponse EndGetQAppSession(IAsyncResult asyncResult)
        {
            return EndInvoke<GetQAppSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetQAppSessionMetadata

        /// <summary>
        /// Retrieves the current configuration of a Q App session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQAppSessionMetadata service method.</param>
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
        public virtual GetQAppSessionMetadataResponse GetQAppSessionMetadata(GetQAppSessionMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQAppSessionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQAppSessionMetadataResponseUnmarshaller.Instance;

            return Invoke<GetQAppSessionMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetQAppSessionMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQAppSessionMetadata operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQAppSessionMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetQAppSessionMetadata">REST API Reference for GetQAppSessionMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetQAppSessionMetadata(GetQAppSessionMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQAppSessionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQAppSessionMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetQAppSessionMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQAppSessionMetadata.</param>
        /// 
        /// <returns>Returns a  GetQAppSessionMetadataResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/GetQAppSessionMetadata">REST API Reference for GetQAppSessionMetadata Operation</seealso>
        public virtual GetQAppSessionMetadataResponse EndGetQAppSessionMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetQAppSessionMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportDocument

        /// <summary>
        /// Uploads a file that can then be used either as a default in a <c>FileUploadCard</c>
        /// from Q App definition or as a file that is used inside a single Q App run. The purpose
        /// of the document is determined by a scope parameter that indicates whether it is at
        /// the app definition level or at the app session level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportDocument service method.</param>
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
        public virtual ImportDocumentResponse ImportDocument(ImportDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportDocumentResponseUnmarshaller.Instance;

            return Invoke<ImportDocumentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportDocument operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportDocument
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ImportDocument">REST API Reference for ImportDocument Operation</seealso>
        public virtual IAsyncResult BeginImportDocument(ImportDocumentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportDocumentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportDocument.</param>
        /// 
        /// <returns>Returns a  ImportDocumentResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ImportDocument">REST API Reference for ImportDocument Operation</seealso>
        public virtual ImportDocumentResponse EndImportDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportDocumentResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCategories

        /// <summary>
        /// Lists the categories of a Amazon Q Business application environment instance. For
        /// more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/qapps-custom-labels.html">Custom
        /// labels for Amazon Q Apps</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCategories service method.</param>
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
        public virtual ListCategoriesResponse ListCategories(ListCategoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCategoriesResponseUnmarshaller.Instance;

            return Invoke<ListCategoriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCategories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCategories operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCategories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListCategories">REST API Reference for ListCategories Operation</seealso>
        public virtual IAsyncResult BeginListCategories(ListCategoriesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCategoriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCategories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCategories.</param>
        /// 
        /// <returns>Returns a  ListCategoriesResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListCategories">REST API Reference for ListCategories Operation</seealso>
        public virtual ListCategoriesResponse EndListCategories(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCategoriesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLibraryItems

        /// <summary>
        /// Lists the library items for Amazon Q Apps that are published and available for users
        /// in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLibraryItems service method.</param>
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
        public virtual ListLibraryItemsResponse ListLibraryItems(ListLibraryItemsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLibraryItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLibraryItemsResponseUnmarshaller.Instance;

            return Invoke<ListLibraryItemsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLibraryItems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLibraryItems operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLibraryItems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListLibraryItems">REST API Reference for ListLibraryItems Operation</seealso>
        public virtual IAsyncResult BeginListLibraryItems(ListLibraryItemsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLibraryItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLibraryItemsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLibraryItems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLibraryItems.</param>
        /// 
        /// <returns>Returns a  ListLibraryItemsResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListLibraryItems">REST API Reference for ListLibraryItems Operation</seealso>
        public virtual ListLibraryItemsResponse EndListLibraryItems(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLibraryItemsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListQApps

        /// <summary>
        /// Lists the Amazon Q Apps owned by or associated with the user either because they created
        /// it or because they used it from the library in the past. The user identity is extracted
        /// from the credentials used to invoke this operation..
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQApps service method.</param>
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
        public virtual ListQAppsResponse ListQApps(ListQAppsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQAppsResponseUnmarshaller.Instance;

            return Invoke<ListQAppsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListQApps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQApps operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQApps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListQApps">REST API Reference for ListQApps Operation</seealso>
        public virtual IAsyncResult BeginListQApps(ListQAppsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQAppsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListQApps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQApps.</param>
        /// 
        /// <returns>Returns a  ListQAppsResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListQApps">REST API Reference for ListQApps Operation</seealso>
        public virtual ListQAppsResponse EndListQApps(IAsyncResult asyncResult)
        {
            return EndInvoke<ListQAppsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListQAppSessionData

        /// <summary>
        /// Lists the collected data of a Q App data collection session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQAppSessionData service method.</param>
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
        public virtual ListQAppSessionDataResponse ListQAppSessionData(ListQAppSessionDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQAppSessionDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQAppSessionDataResponseUnmarshaller.Instance;

            return Invoke<ListQAppSessionDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListQAppSessionData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQAppSessionData operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQAppSessionData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListQAppSessionData">REST API Reference for ListQAppSessionData Operation</seealso>
        public virtual IAsyncResult BeginListQAppSessionData(ListQAppSessionDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQAppSessionDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQAppSessionDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListQAppSessionData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQAppSessionData.</param>
        /// 
        /// <returns>Returns a  ListQAppSessionDataResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListQAppSessionData">REST API Reference for ListQAppSessionData Operation</seealso>
        public virtual ListQAppSessionDataResponse EndListQAppSessionData(IAsyncResult asyncResult)
        {
            return EndInvoke<ListQAppSessionDataResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags associated with an Amazon Q Apps resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PredictQApp

        /// <summary>
        /// Generates an Amazon Q App definition based on either a conversation or a problem statement
        /// provided as input.The resulting app definition can be used to call <c>CreateQApp</c>.
        /// This API doesn't create Amazon Q Apps directly.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PredictQApp service method.</param>
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
        public virtual PredictQAppResponse PredictQApp(PredictQAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PredictQAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PredictQAppResponseUnmarshaller.Instance;

            return Invoke<PredictQAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PredictQApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PredictQApp operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPredictQApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/PredictQApp">REST API Reference for PredictQApp Operation</seealso>
        public virtual IAsyncResult BeginPredictQApp(PredictQAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PredictQAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PredictQAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PredictQApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPredictQApp.</param>
        /// 
        /// <returns>Returns a  PredictQAppResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/PredictQApp">REST API Reference for PredictQApp Operation</seealso>
        public virtual PredictQAppResponse EndPredictQApp(IAsyncResult asyncResult)
        {
            return EndInvoke<PredictQAppResponse>(asyncResult);
        }

        #endregion
        
        #region  StartQAppSession

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
        public virtual StartQAppSessionResponse StartQAppSession(StartQAppSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartQAppSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQAppSessionResponseUnmarshaller.Instance;

            return Invoke<StartQAppSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartQAppSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartQAppSession operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartQAppSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/StartQAppSession">REST API Reference for StartQAppSession Operation</seealso>
        public virtual IAsyncResult BeginStartQAppSession(StartQAppSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartQAppSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQAppSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartQAppSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartQAppSession.</param>
        /// 
        /// <returns>Returns a  StartQAppSessionResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/StartQAppSession">REST API Reference for StartQAppSession Operation</seealso>
        public virtual StartQAppSessionResponse EndStartQAppSession(IAsyncResult asyncResult)
        {
            return EndInvoke<StartQAppSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  StopQAppSession

        /// <summary>
        /// Stops an active session for an Amazon Q App.This deletes all data related to the session
        /// and makes it invalid for future uses. The results of the session will be persisted
        /// as part of the conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopQAppSession service method.</param>
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
        public virtual StopQAppSessionResponse StopQAppSession(StopQAppSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopQAppSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQAppSessionResponseUnmarshaller.Instance;

            return Invoke<StopQAppSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopQAppSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopQAppSession operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopQAppSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/StopQAppSession">REST API Reference for StopQAppSession Operation</seealso>
        public virtual IAsyncResult BeginStopQAppSession(StopQAppSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopQAppSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQAppSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopQAppSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopQAppSession.</param>
        /// 
        /// <returns>Returns a  StopQAppSessionResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/StopQAppSession">REST API Reference for StopQAppSession Operation</seealso>
        public virtual StopQAppSessionResponse EndStopQAppSession(IAsyncResult asyncResult)
        {
            return EndInvoke<StopQAppSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Associates tags with an Amazon Q Apps resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Disassociates tags from an Amazon Q Apps resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLibraryItem

        /// <summary>
        /// Updates the library item for an Amazon Q App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLibraryItem service method.</param>
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
        public virtual UpdateLibraryItemResponse UpdateLibraryItem(UpdateLibraryItemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLibraryItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLibraryItemResponseUnmarshaller.Instance;

            return Invoke<UpdateLibraryItemResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLibraryItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLibraryItem operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLibraryItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateLibraryItem">REST API Reference for UpdateLibraryItem Operation</seealso>
        public virtual IAsyncResult BeginUpdateLibraryItem(UpdateLibraryItemRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLibraryItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLibraryItemResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLibraryItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLibraryItem.</param>
        /// 
        /// <returns>Returns a  UpdateLibraryItemResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateLibraryItem">REST API Reference for UpdateLibraryItem Operation</seealso>
        public virtual UpdateLibraryItemResponse EndUpdateLibraryItem(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLibraryItemResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLibraryItemMetadata

        /// <summary>
        /// Updates the verification status of a library item for an Amazon Q App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLibraryItemMetadata service method.</param>
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
        public virtual UpdateLibraryItemMetadataResponse UpdateLibraryItemMetadata(UpdateLibraryItemMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLibraryItemMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLibraryItemMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateLibraryItemMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLibraryItemMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLibraryItemMetadata operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLibraryItemMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateLibraryItemMetadata">REST API Reference for UpdateLibraryItemMetadata Operation</seealso>
        public virtual IAsyncResult BeginUpdateLibraryItemMetadata(UpdateLibraryItemMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLibraryItemMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLibraryItemMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLibraryItemMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLibraryItemMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateLibraryItemMetadataResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateLibraryItemMetadata">REST API Reference for UpdateLibraryItemMetadata Operation</seealso>
        public virtual UpdateLibraryItemMetadataResponse EndUpdateLibraryItemMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLibraryItemMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateQApp

        /// <summary>
        /// Updates an existing Amazon Q App, allowing modifications to its title, description,
        /// and definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQApp service method.</param>
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
        public virtual UpdateQAppResponse UpdateQApp(UpdateQAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQAppResponseUnmarshaller.Instance;

            return Invoke<UpdateQAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQApp operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQApp">REST API Reference for UpdateQApp Operation</seealso>
        public virtual IAsyncResult BeginUpdateQApp(UpdateQAppRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQApp.</param>
        /// 
        /// <returns>Returns a  UpdateQAppResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQApp">REST API Reference for UpdateQApp Operation</seealso>
        public virtual UpdateQAppResponse EndUpdateQApp(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateQAppResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateQAppPermissions

        /// <summary>
        /// Updates read permissions for a Amazon Q App in Amazon Q Business application environment
        /// instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQAppPermissions service method.</param>
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
        public virtual UpdateQAppPermissionsResponse UpdateQAppPermissions(UpdateQAppPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQAppPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQAppPermissionsResponseUnmarshaller.Instance;

            return Invoke<UpdateQAppPermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQAppPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQAppPermissions operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQAppPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQAppPermissions">REST API Reference for UpdateQAppPermissions Operation</seealso>
        public virtual IAsyncResult BeginUpdateQAppPermissions(UpdateQAppPermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQAppPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQAppPermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQAppPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQAppPermissions.</param>
        /// 
        /// <returns>Returns a  UpdateQAppPermissionsResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQAppPermissions">REST API Reference for UpdateQAppPermissions Operation</seealso>
        public virtual UpdateQAppPermissionsResponse EndUpdateQAppPermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateQAppPermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateQAppSession

        /// <summary>
        /// Updates the session for a given Q App <c>sessionId</c>. This is only valid when at
        /// least one card of the session is in the <c>WAITING</c> state. Data for each <c>WAITING</c>
        /// card can be provided as input. If inputs are not provided, the call will be accepted
        /// but session will not move forward. Inputs for cards that are not in the <c>WAITING</c>
        /// status will be ignored.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQAppSession service method.</param>
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
        public virtual UpdateQAppSessionResponse UpdateQAppSession(UpdateQAppSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQAppSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQAppSessionResponseUnmarshaller.Instance;

            return Invoke<UpdateQAppSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQAppSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQAppSession operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQAppSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQAppSession">REST API Reference for UpdateQAppSession Operation</seealso>
        public virtual IAsyncResult BeginUpdateQAppSession(UpdateQAppSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQAppSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQAppSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQAppSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQAppSession.</param>
        /// 
        /// <returns>Returns a  UpdateQAppSessionResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQAppSession">REST API Reference for UpdateQAppSession Operation</seealso>
        public virtual UpdateQAppSessionResponse EndUpdateQAppSession(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateQAppSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateQAppSessionMetadata

        /// <summary>
        /// Updates the configuration metadata of a session for a given Q App <c>sessionId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQAppSessionMetadata service method.</param>
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
        public virtual UpdateQAppSessionMetadataResponse UpdateQAppSessionMetadata(UpdateQAppSessionMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQAppSessionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQAppSessionMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateQAppSessionMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQAppSessionMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQAppSessionMetadata operation on AmazonQAppsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQAppSessionMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQAppSessionMetadata">REST API Reference for UpdateQAppSessionMetadata Operation</seealso>
        public virtual IAsyncResult BeginUpdateQAppSessionMetadata(UpdateQAppSessionMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQAppSessionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQAppSessionMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQAppSessionMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQAppSessionMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateQAppSessionMetadataResult from QApps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qapps-2023-11-27/UpdateQAppSessionMetadata">REST API Reference for UpdateQAppSessionMetadata Operation</seealso>
        public virtual UpdateQAppSessionMetadataResponse EndUpdateQAppSessionMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateQAppSessionMetadataResponse>(asyncResult);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonQAppsEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}