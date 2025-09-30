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
 * Do not modify this file. This file is generated from the repostspace-2022-05-13.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Repostspace.Model;
using Amazon.Repostspace.Model.Internal.MarshallTransformations;
using Amazon.Repostspace.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.Repostspace
{
    /// <summary>
    /// <para>Implementation for accessing Repostspace</para>
    ///
    /// AWS re:Post Private is a private version of AWS re:Post for enterprises with Enterprise
    /// Support or Enterprise On-Ramp Support plans. It provides access to knowledge and experts
    /// to accelerate cloud adoption and increase developer productivity. With your organization-specific
    /// private re:Post, you can build an organization-specific developer community that drives
    /// efficiencies at scale and provides access to valuable knowledge resources. Additionally,
    /// re:Post Private centralizes trusted AWS technical content and offers private discussion
    /// forums to improve how your teams collaborate internally and with AWS to remove technical
    /// obstacles, accelerate innovation, and scale more efficiently in the cloud.
    /// </summary>
    public partial class AmazonRepostspaceClient : AmazonServiceClient, IAmazonRepostspace
    {
        private static IServiceMetadata serviceMetadata = new AmazonRepostspaceMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IRepostspacePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IRepostspacePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new RepostspacePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonRepostspaceClient with the credentials loaded from the application's
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
        public AmazonRepostspaceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRepostspaceConfig()) { }

        /// <summary>
        /// Constructs AmazonRepostspaceClient with the credentials loaded from the application's
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
        public AmazonRepostspaceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRepostspaceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRepostspaceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRepostspaceClient Configuration Object</param>
        public AmazonRepostspaceClient(AmazonRepostspaceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonRepostspaceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRepostspaceClient(AWSCredentials credentials)
            : this(credentials, new AmazonRepostspaceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRepostspaceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRepostspaceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRepostspaceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRepostspaceClient with AWS Credentials and an
        /// AmazonRepostspaceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRepostspaceClient Configuration Object</param>
        public AmazonRepostspaceClient(AWSCredentials credentials, AmazonRepostspaceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRepostspaceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRepostspaceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRepostspaceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRepostspaceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRepostspaceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRepostspaceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRepostspaceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRepostspaceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRepostspaceClient Configuration Object</param>
        public AmazonRepostspaceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRepostspaceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRepostspaceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRepostspaceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRepostspaceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRepostspaceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRepostspaceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRepostspaceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRepostspaceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRepostspaceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRepostspaceClient Configuration Object</param>
        public AmazonRepostspaceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRepostspaceConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRepostspaceEndpointResolver());
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


        #region  BatchAddChannelRoleToAccessors

        /// <summary>
        /// Add role to multiple users or groups in a private re:Post channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAddChannelRoleToAccessors service method.</param>
        /// 
        /// <returns>The response from the BatchAddChannelRoleToAccessors service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/BatchAddChannelRoleToAccessors">REST API Reference for BatchAddChannelRoleToAccessors Operation</seealso>
        public virtual BatchAddChannelRoleToAccessorsResponse BatchAddChannelRoleToAccessors(BatchAddChannelRoleToAccessorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAddChannelRoleToAccessorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAddChannelRoleToAccessorsResponseUnmarshaller.Instance;

            return Invoke<BatchAddChannelRoleToAccessorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchAddChannelRoleToAccessors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchAddChannelRoleToAccessors operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchAddChannelRoleToAccessors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/BatchAddChannelRoleToAccessors">REST API Reference for BatchAddChannelRoleToAccessors Operation</seealso>
        public virtual IAsyncResult BeginBatchAddChannelRoleToAccessors(BatchAddChannelRoleToAccessorsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAddChannelRoleToAccessorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAddChannelRoleToAccessorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchAddChannelRoleToAccessors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchAddChannelRoleToAccessors.</param>
        /// 
        /// <returns>Returns a  BatchAddChannelRoleToAccessorsResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/BatchAddChannelRoleToAccessors">REST API Reference for BatchAddChannelRoleToAccessors Operation</seealso>
        public virtual BatchAddChannelRoleToAccessorsResponse EndBatchAddChannelRoleToAccessors(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchAddChannelRoleToAccessorsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchAddRole

        /// <summary>
        /// Add a role to multiple users or groups in a private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAddRole service method.</param>
        /// 
        /// <returns>The response from the BatchAddRole service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/BatchAddRole">REST API Reference for BatchAddRole Operation</seealso>
        public virtual BatchAddRoleResponse BatchAddRole(BatchAddRoleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAddRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAddRoleResponseUnmarshaller.Instance;

            return Invoke<BatchAddRoleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchAddRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchAddRole operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchAddRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/BatchAddRole">REST API Reference for BatchAddRole Operation</seealso>
        public virtual IAsyncResult BeginBatchAddRole(BatchAddRoleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAddRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAddRoleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchAddRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchAddRole.</param>
        /// 
        /// <returns>Returns a  BatchAddRoleResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/BatchAddRole">REST API Reference for BatchAddRole Operation</seealso>
        public virtual BatchAddRoleResponse EndBatchAddRole(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchAddRoleResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchRemoveChannelRoleFromAccessors

        /// <summary>
        /// Remove a role from multiple users or groups in a private re:Post channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchRemoveChannelRoleFromAccessors service method.</param>
        /// 
        /// <returns>The response from the BatchRemoveChannelRoleFromAccessors service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/BatchRemoveChannelRoleFromAccessors">REST API Reference for BatchRemoveChannelRoleFromAccessors Operation</seealso>
        public virtual BatchRemoveChannelRoleFromAccessorsResponse BatchRemoveChannelRoleFromAccessors(BatchRemoveChannelRoleFromAccessorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchRemoveChannelRoleFromAccessorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchRemoveChannelRoleFromAccessorsResponseUnmarshaller.Instance;

            return Invoke<BatchRemoveChannelRoleFromAccessorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchRemoveChannelRoleFromAccessors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchRemoveChannelRoleFromAccessors operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchRemoveChannelRoleFromAccessors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/BatchRemoveChannelRoleFromAccessors">REST API Reference for BatchRemoveChannelRoleFromAccessors Operation</seealso>
        public virtual IAsyncResult BeginBatchRemoveChannelRoleFromAccessors(BatchRemoveChannelRoleFromAccessorsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchRemoveChannelRoleFromAccessorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchRemoveChannelRoleFromAccessorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchRemoveChannelRoleFromAccessors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchRemoveChannelRoleFromAccessors.</param>
        /// 
        /// <returns>Returns a  BatchRemoveChannelRoleFromAccessorsResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/BatchRemoveChannelRoleFromAccessors">REST API Reference for BatchRemoveChannelRoleFromAccessors Operation</seealso>
        public virtual BatchRemoveChannelRoleFromAccessorsResponse EndBatchRemoveChannelRoleFromAccessors(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchRemoveChannelRoleFromAccessorsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchRemoveRole

        /// <summary>
        /// Remove a role from multiple users or groups in a private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchRemoveRole service method.</param>
        /// 
        /// <returns>The response from the BatchRemoveRole service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/BatchRemoveRole">REST API Reference for BatchRemoveRole Operation</seealso>
        public virtual BatchRemoveRoleResponse BatchRemoveRole(BatchRemoveRoleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchRemoveRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchRemoveRoleResponseUnmarshaller.Instance;

            return Invoke<BatchRemoveRoleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchRemoveRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchRemoveRole operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchRemoveRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/BatchRemoveRole">REST API Reference for BatchRemoveRole Operation</seealso>
        public virtual IAsyncResult BeginBatchRemoveRole(BatchRemoveRoleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchRemoveRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchRemoveRoleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchRemoveRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchRemoveRole.</param>
        /// 
        /// <returns>Returns a  BatchRemoveRoleResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/BatchRemoveRole">REST API Reference for BatchRemoveRole Operation</seealso>
        public virtual BatchRemoveRoleResponse EndBatchRemoveRole(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchRemoveRoleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateChannel

        /// <summary>
        /// Creates a channel in an AWS re:Post Private private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual CreateChannelResponse CreateChannel(CreateChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return Invoke<CreateChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual IAsyncResult BeginCreateChannel(CreateChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannel.</param>
        /// 
        /// <returns>Returns a  CreateChannelResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual CreateChannelResponse EndCreateChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSpace

        /// <summary>
        /// Creates an AWS re:Post Private private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSpace service method.</param>
        /// 
        /// <returns>The response from the CreateSpace service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/CreateSpace">REST API Reference for CreateSpace Operation</seealso>
        public virtual CreateSpaceResponse CreateSpace(CreateSpaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSpaceResponseUnmarshaller.Instance;

            return Invoke<CreateSpaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSpace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSpace operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSpace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/CreateSpace">REST API Reference for CreateSpace Operation</seealso>
        public virtual IAsyncResult BeginCreateSpace(CreateSpaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSpaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSpace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSpace.</param>
        /// 
        /// <returns>Returns a  CreateSpaceResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/CreateSpace">REST API Reference for CreateSpace Operation</seealso>
        public virtual CreateSpaceResponse EndCreateSpace(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSpaceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSpace

        /// <summary>
        /// Deletes an AWS re:Post Private private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpace service method.</param>
        /// 
        /// <returns>The response from the DeleteSpace service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/DeleteSpace">REST API Reference for DeleteSpace Operation</seealso>
        public virtual DeleteSpaceResponse DeleteSpace(DeleteSpaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSpaceResponseUnmarshaller.Instance;

            return Invoke<DeleteSpaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSpace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpace operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSpace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/DeleteSpace">REST API Reference for DeleteSpace Operation</seealso>
        public virtual IAsyncResult BeginDeleteSpace(DeleteSpaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSpaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSpace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSpace.</param>
        /// 
        /// <returns>Returns a  DeleteSpaceResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/DeleteSpace">REST API Reference for DeleteSpace Operation</seealso>
        public virtual DeleteSpaceResponse EndDeleteSpace(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSpaceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterAdmin

        /// <summary>
        /// Removes the user or group from the list of administrators of the private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterAdmin service method.</param>
        /// 
        /// <returns>The response from the DeregisterAdmin service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/DeregisterAdmin">REST API Reference for DeregisterAdmin Operation</seealso>
        public virtual DeregisterAdminResponse DeregisterAdmin(DeregisterAdminRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterAdminResponseUnmarshaller.Instance;

            return Invoke<DeregisterAdminResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterAdmin operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterAdmin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/DeregisterAdmin">REST API Reference for DeregisterAdmin Operation</seealso>
        public virtual IAsyncResult BeginDeregisterAdmin(DeregisterAdminRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterAdminResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterAdmin.</param>
        /// 
        /// <returns>Returns a  DeregisterAdminResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/DeregisterAdmin">REST API Reference for DeregisterAdmin Operation</seealso>
        public virtual DeregisterAdminResponse EndDeregisterAdmin(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterAdminResponse>(asyncResult);
        }

        #endregion
        
        #region  GetChannel

        /// <summary>
        /// Displays information about a channel in a private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannel service method.</param>
        /// 
        /// <returns>The response from the GetChannel service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/GetChannel">REST API Reference for GetChannel Operation</seealso>
        public virtual GetChannelResponse GetChannel(GetChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelResponseUnmarshaller.Instance;

            return Invoke<GetChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChannel operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/GetChannel">REST API Reference for GetChannel Operation</seealso>
        public virtual IAsyncResult BeginGetChannel(GetChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChannel.</param>
        /// 
        /// <returns>Returns a  GetChannelResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/GetChannel">REST API Reference for GetChannel Operation</seealso>
        public virtual GetChannelResponse EndGetChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSpace

        /// <summary>
        /// Displays information about the AWS re:Post Private private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpace service method.</param>
        /// 
        /// <returns>The response from the GetSpace service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/GetSpace">REST API Reference for GetSpace Operation</seealso>
        public virtual GetSpaceResponse GetSpace(GetSpaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpaceResponseUnmarshaller.Instance;

            return Invoke<GetSpaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSpace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSpace operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSpace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/GetSpace">REST API Reference for GetSpace Operation</seealso>
        public virtual IAsyncResult BeginGetSpace(GetSpaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSpace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSpace.</param>
        /// 
        /// <returns>Returns a  GetSpaceResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/GetSpace">REST API Reference for GetSpace Operation</seealso>
        public virtual GetSpaceResponse EndGetSpace(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSpaceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannels

        /// <summary>
        /// Returns the list of channel within a private re:Post with some information about each
        /// channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual ListChannelsResponse ListChannels(ListChannelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannels operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual IAsyncResult BeginListChannels(ListChannelsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannels.</param>
        /// 
        /// <returns>Returns a  ListChannelsResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual ListChannelsResponse EndListChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSpaces

        /// <summary>
        /// Returns a list of AWS re:Post Private private re:Posts in the account with some information
        /// about each private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpaces service method.</param>
        /// 
        /// <returns>The response from the ListSpaces service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        public virtual ListSpacesResponse ListSpaces(ListSpacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSpacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpacesResponseUnmarshaller.Instance;

            return Invoke<ListSpacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSpaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSpaces operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSpaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        public virtual IAsyncResult BeginListSpaces(ListSpacesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSpacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSpaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSpaces.</param>
        /// 
        /// <returns>Returns a  ListSpacesResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        public virtual ListSpacesResponse EndListSpaces(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSpacesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns the tags that are associated with the AWS re:Post Private resource specified
        /// by the resourceArn. The only resource that can be tagged is a private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterAdmin

        /// <summary>
        /// Adds a user or group to the list of administrators of the private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAdmin service method.</param>
        /// 
        /// <returns>The response from the RegisterAdmin service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/RegisterAdmin">REST API Reference for RegisterAdmin Operation</seealso>
        public virtual RegisterAdminResponse RegisterAdmin(RegisterAdminRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAdminResponseUnmarshaller.Instance;

            return Invoke<RegisterAdminResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterAdmin operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterAdmin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/RegisterAdmin">REST API Reference for RegisterAdmin Operation</seealso>
        public virtual IAsyncResult BeginRegisterAdmin(RegisterAdminRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAdminResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterAdmin.</param>
        /// 
        /// <returns>Returns a  RegisterAdminResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/RegisterAdmin">REST API Reference for RegisterAdmin Operation</seealso>
        public virtual RegisterAdminResponse EndRegisterAdmin(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterAdminResponse>(asyncResult);
        }

        #endregion
        
        #region  SendInvites

        /// <summary>
        /// Sends an invitation email to selected users and groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendInvites service method.</param>
        /// 
        /// <returns>The response from the SendInvites service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/SendInvites">REST API Reference for SendInvites Operation</seealso>
        public virtual SendInvitesResponse SendInvites(SendInvitesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendInvitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendInvitesResponseUnmarshaller.Instance;

            return Invoke<SendInvitesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendInvites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendInvites operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendInvites
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/SendInvites">REST API Reference for SendInvites Operation</seealso>
        public virtual IAsyncResult BeginSendInvites(SendInvitesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendInvitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendInvitesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendInvites operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendInvites.</param>
        /// 
        /// <returns>Returns a  SendInvitesResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/SendInvites">REST API Reference for SendInvites Operation</seealso>
        public virtual SendInvitesResponse EndSendInvites(IAsyncResult asyncResult)
        {
            return EndInvoke<SendInvitesResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Associates tags with an AWS re:Post Private resource. Currently, the only resource
        /// that can be tagged is the private re:Post. If you specify a new tag key for the resource,
        /// the tag is appended to the list of tags that are associated with the resource. If
        /// you specify a tag key that’s already associated with the resource, the new tag value
        /// that you specify replaces the previous value for that tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes the association of the tag with the AWS re:Post Private resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateChannel

        /// <summary>
        /// Modifies an existing channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual UpdateChannelResponse UpdateChannel(UpdateChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual IAsyncResult BeginUpdateChannel(UpdateChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannel.</param>
        /// 
        /// <returns>Returns a  UpdateChannelResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual UpdateChannelResponse EndUpdateChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSpace

        /// <summary>
        /// Modifies an existing AWS re:Post Private private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSpace service method.</param>
        /// 
        /// <returns>The response from the UpdateSpace service method, as returned by Repostspace.</returns>
        /// <exception cref="Amazon.Repostspace.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Repostspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/UpdateSpace">REST API Reference for UpdateSpace Operation</seealso>
        public virtual UpdateSpaceResponse UpdateSpace(UpdateSpaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSpaceResponseUnmarshaller.Instance;

            return Invoke<UpdateSpaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSpace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSpace operation on AmazonRepostspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSpace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/UpdateSpace">REST API Reference for UpdateSpace Operation</seealso>
        public virtual IAsyncResult BeginUpdateSpace(UpdateSpaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSpaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSpace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSpace.</param>
        /// 
        /// <returns>Returns a  UpdateSpaceResult from Repostspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/repostspace-2022-05-13/UpdateSpace">REST API Reference for UpdateSpace Operation</seealso>
        public virtual UpdateSpaceResponse EndUpdateSpace(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSpaceResponse>(asyncResult);
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
            var resolver = new AmazonRepostspaceEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}