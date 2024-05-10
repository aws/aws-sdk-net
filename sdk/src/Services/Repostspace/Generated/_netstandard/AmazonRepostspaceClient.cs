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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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
#if AWS_ASYNC_ENUMERABLES_API
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

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
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


        #region  CreateSpace

        internal virtual CreateSpaceResponse CreateSpace(CreateSpaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSpaceResponseUnmarshaller.Instance;

            return Invoke<CreateSpaceResponse>(request, options);
        }



        /// <summary>
        /// Creates an AWS re:Post Private private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateSpaceResponse> CreateSpaceAsync(CreateSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSpaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSpaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSpace

        internal virtual DeleteSpaceResponse DeleteSpace(DeleteSpaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSpaceResponseUnmarshaller.Instance;

            return Invoke<DeleteSpaceResponse>(request, options);
        }



        /// <summary>
        /// Deletes an AWS re:Post Private private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteSpaceResponse> DeleteSpaceAsync(DeleteSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSpaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSpaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterAdmin

        internal virtual DeregisterAdminResponse DeregisterAdmin(DeregisterAdminRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterAdminResponseUnmarshaller.Instance;

            return Invoke<DeregisterAdminResponse>(request, options);
        }



        /// <summary>
        /// Removes the user or group from the list of administrators of the private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeregisterAdminResponse> DeregisterAdminAsync(DeregisterAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterAdminResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterAdminResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSpace

        internal virtual GetSpaceResponse GetSpace(GetSpaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpaceResponseUnmarshaller.Instance;

            return Invoke<GetSpaceResponse>(request, options);
        }



        /// <summary>
        /// Displays information about the AWS re:Post Private private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetSpaceResponse> GetSpaceAsync(GetSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpaceResponseUnmarshaller.Instance;

            return InvokeAsync<GetSpaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSpaces

        internal virtual ListSpacesResponse ListSpaces(ListSpacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSpacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpacesResponseUnmarshaller.Instance;

            return Invoke<ListSpacesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of AWS re:Post Private private re:Posts in the account with some information
        /// about each private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListSpacesResponse> ListSpacesAsync(ListSpacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSpacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpacesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSpacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Returns the tags that are associated with the AWS re:Post Private resource specified
        /// by the resourceArn. The only resource that can be tagged is a private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterAdmin

        internal virtual RegisterAdminResponse RegisterAdmin(RegisterAdminRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAdminResponseUnmarshaller.Instance;

            return Invoke<RegisterAdminResponse>(request, options);
        }



        /// <summary>
        /// Adds a user or group to the list of administrators of the private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RegisterAdminResponse> RegisterAdminAsync(RegisterAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAdminResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterAdminResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendInvites

        internal virtual SendInvitesResponse SendInvites(SendInvitesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendInvitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendInvitesResponseUnmarshaller.Instance;

            return Invoke<SendInvitesResponse>(request, options);
        }



        /// <summary>
        /// Sends an invitation email to selected users and groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendInvites service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<SendInvitesResponse> SendInvitesAsync(SendInvitesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendInvitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendInvitesResponseUnmarshaller.Instance;

            return InvokeAsync<SendInvitesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Associates tags with an AWS re:Post Private resource. Currently, the only resource
        /// that can be tagged is the private re:Post. If you specify a new tag key for the resource,
        /// the tag is appended to the list of tags that are associated with the resource. If
        /// you specify a tag key that’s already associated with the resource, the new tag value
        /// that you specify replaces the previous value for that tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes the association of the tag with the AWS re:Post Private resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSpace

        internal virtual UpdateSpaceResponse UpdateSpace(UpdateSpaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSpaceResponseUnmarshaller.Instance;

            return Invoke<UpdateSpaceResponse>(request, options);
        }



        /// <summary>
        /// Modifies an existing AWS re:Post Private private re:Post.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateSpaceResponse> UpdateSpaceAsync(UpdateSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSpaceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSpaceResponse>(request, options, cancellationToken);
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
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonRepostspaceEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}