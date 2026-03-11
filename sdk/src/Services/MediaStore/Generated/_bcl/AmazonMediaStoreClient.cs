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
 * Do not modify this file. This file is generated from the mediastore-2017-09-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MediaStore.Model;
using Amazon.MediaStore.Model.Internal.MarshallTransformations;
using Amazon.MediaStore.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.MediaStore
{
    /// <summary>
    /// <para>Implementation for accessing MediaStore</para>
    ///
    /// An AWS Elemental MediaStore container is a namespace that holds folders and objects.
    /// You use a container endpoint to create, read, and delete objects.
    /// </summary>
    public partial class AmazonMediaStoreClient : AmazonServiceClient, IAmazonMediaStore
    {
        private static IServiceMetadata serviceMetadata = new AmazonMediaStoreMetadata();
        private IMediaStorePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMediaStorePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MediaStorePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonMediaStoreClient with the credentials loaded from the application's
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
        public AmazonMediaStoreClient()
            : base(new AmazonMediaStoreConfig()) { }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with the credentials loaded from the application's
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
        public AmazonMediaStoreClient(RegionEndpoint region)
            : base(new AmazonMediaStoreConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMediaStoreClient Configuration Object</param>
        public AmazonMediaStoreClient(AmazonMediaStoreConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMediaStoreClient(AWSCredentials credentials)
            : this(credentials, new AmazonMediaStoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaStoreClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMediaStoreConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Credentials and an
        /// AmazonMediaStoreClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMediaStoreClient Configuration Object</param>
        public AmazonMediaStoreClient(AWSCredentials credentials, AmazonMediaStoreConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMediaStoreClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaStoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaStoreClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaStoreConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaStoreClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMediaStoreClient Configuration Object</param>
        public AmazonMediaStoreClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMediaStoreConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMediaStoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaStoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaStoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaStoreConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaStoreClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaStoreClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMediaStoreClient Configuration Object</param>
        public AmazonMediaStoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMediaStoreConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMediaStoreEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMediaStoreAuthSchemeHandler());
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


        #region  CreateContainer


        /// <summary>
        /// Creates a storage container to hold objects. A container is similar to a bucket in
        /// the Amazon S3 service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContainer service method.</param>
        /// 
        /// <returns>The response from the CreateContainer service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.LimitExceededException">
        /// A service limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/CreateContainer">REST API Reference for CreateContainer Operation</seealso>
        public virtual CreateContainerResponse CreateContainer(CreateContainerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContainerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContainerResponseUnmarshaller.Instance;

            return Invoke<CreateContainerResponse>(request, options);
        }


        /// <summary>
        /// Creates a storage container to hold objects. A container is similar to a bucket in
        /// the Amazon S3 service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContainer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateContainer service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.LimitExceededException">
        /// A service limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/CreateContainer">REST API Reference for CreateContainer Operation</seealso>
        public virtual Task<CreateContainerResponse> CreateContainerAsync(CreateContainerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContainerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContainerResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateContainerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteContainer


        /// <summary>
        /// Deletes the specified container. Before you make a <c>DeleteContainer</c> request,
        /// delete any objects in the container or in any folders in the container. You can delete
        /// only empty containers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainer service method.</param>
        /// 
        /// <returns>The response from the DeleteContainer service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteContainer">REST API Reference for DeleteContainer Operation</seealso>
        public virtual DeleteContainerResponse DeleteContainer(DeleteContainerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContainerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerResponseUnmarshaller.Instance;

            return Invoke<DeleteContainerResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified container. Before you make a <c>DeleteContainer</c> request,
        /// delete any objects in the container or in any folders in the container. You can delete
        /// only empty containers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteContainer service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteContainer">REST API Reference for DeleteContainer Operation</seealso>
        public virtual Task<DeleteContainerResponse> DeleteContainerAsync(DeleteContainerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContainerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteContainerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteContainerPolicy


        /// <summary>
        /// Deletes the access policy that is associated with the specified container.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainerPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteContainerPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.PolicyNotFoundException">
        /// The policy that you specified in the request does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteContainerPolicy">REST API Reference for DeleteContainerPolicy Operation</seealso>
        public virtual DeleteContainerPolicyResponse DeleteContainerPolicy(DeleteContainerPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContainerPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteContainerPolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes the access policy that is associated with the specified container.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainerPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteContainerPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.PolicyNotFoundException">
        /// The policy that you specified in the request does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteContainerPolicy">REST API Reference for DeleteContainerPolicy Operation</seealso>
        public virtual Task<DeleteContainerPolicyResponse> DeleteContainerPolicyAsync(DeleteContainerPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContainerPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteContainerPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCorsPolicy


        /// <summary>
        /// Deletes the cross-origin resource sharing (CORS) configuration information that is
        /// set for the container.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <c>MediaStore:DeleteCorsPolicy</c>
        /// action. The container owner has this permission by default and can grant this permission
        /// to others.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCorsPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteCorsPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.CorsPolicyNotFoundException">
        /// The CORS policy that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteCorsPolicy">REST API Reference for DeleteCorsPolicy Operation</seealso>
        public virtual DeleteCorsPolicyResponse DeleteCorsPolicy(DeleteCorsPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCorsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCorsPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteCorsPolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes the cross-origin resource sharing (CORS) configuration information that is
        /// set for the container.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <c>MediaStore:DeleteCorsPolicy</c>
        /// action. The container owner has this permission by default and can grant this permission
        /// to others.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCorsPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCorsPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.CorsPolicyNotFoundException">
        /// The CORS policy that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteCorsPolicy">REST API Reference for DeleteCorsPolicy Operation</seealso>
        public virtual Task<DeleteCorsPolicyResponse> DeleteCorsPolicyAsync(DeleteCorsPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCorsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCorsPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCorsPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLifecyclePolicy


        /// <summary>
        /// Removes an object lifecycle policy from a container. It takes up to 20 minutes for
        /// the change to take effect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecyclePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteLifecyclePolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.PolicyNotFoundException">
        /// The policy that you specified in the request does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteLifecyclePolicy">REST API Reference for DeleteLifecyclePolicy Operation</seealso>
        public virtual DeleteLifecyclePolicyResponse DeleteLifecyclePolicy(DeleteLifecyclePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteLifecyclePolicyResponse>(request, options);
        }


        /// <summary>
        /// Removes an object lifecycle policy from a container. It takes up to 20 minutes for
        /// the change to take effect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecyclePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLifecyclePolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.PolicyNotFoundException">
        /// The policy that you specified in the request does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteLifecyclePolicy">REST API Reference for DeleteLifecyclePolicy Operation</seealso>
        public virtual Task<DeleteLifecyclePolicyResponse> DeleteLifecyclePolicyAsync(DeleteLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecyclePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteLifecyclePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMetricPolicy


        /// <summary>
        /// Deletes the metric policy that is associated with the specified container. If there
        /// is no metric policy associated with the container, MediaStore doesn't send metrics
        /// to CloudWatch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMetricPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteMetricPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.PolicyNotFoundException">
        /// The policy that you specified in the request does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteMetricPolicy">REST API Reference for DeleteMetricPolicy Operation</seealso>
        public virtual DeleteMetricPolicyResponse DeleteMetricPolicy(DeleteMetricPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMetricPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMetricPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteMetricPolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes the metric policy that is associated with the specified container. If there
        /// is no metric policy associated with the container, MediaStore doesn't send metrics
        /// to CloudWatch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMetricPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMetricPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.PolicyNotFoundException">
        /// The policy that you specified in the request does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteMetricPolicy">REST API Reference for DeleteMetricPolicy Operation</seealso>
        public virtual Task<DeleteMetricPolicyResponse> DeleteMetricPolicyAsync(DeleteMetricPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMetricPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMetricPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMetricPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeContainer


        /// <summary>
        /// Retrieves the properties of the requested container. This request is commonly used
        /// to retrieve the endpoint of a container. An endpoint is a value assigned by the service
        /// when a new container is created. A container's endpoint does not change after it has
        /// been assigned. The <c>DescribeContainer</c> request returns a single <c>Container</c>
        /// object based on <c>ContainerName</c>. To return all <c>Container</c> objects that
        /// are associated with a specified AWS account, use <a>ListContainers</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContainer service method.</param>
        /// 
        /// <returns>The response from the DescribeContainer service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DescribeContainer">REST API Reference for DescribeContainer Operation</seealso>
        public virtual DescribeContainerResponse DescribeContainer(DescribeContainerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeContainerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContainerResponseUnmarshaller.Instance;

            return Invoke<DescribeContainerResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the properties of the requested container. This request is commonly used
        /// to retrieve the endpoint of a container. An endpoint is a value assigned by the service
        /// when a new container is created. A container's endpoint does not change after it has
        /// been assigned. The <c>DescribeContainer</c> request returns a single <c>Container</c>
        /// object based on <c>ContainerName</c>. To return all <c>Container</c> objects that
        /// are associated with a specified AWS account, use <a>ListContainers</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContainer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeContainer service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DescribeContainer">REST API Reference for DescribeContainer Operation</seealso>
        public virtual Task<DescribeContainerResponse> DescribeContainerAsync(DescribeContainerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeContainerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContainerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeContainerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetContainerPolicy


        /// <summary>
        /// Retrieves the access policy for the specified container. For information about the
        /// data that is included in an access policy, see the <a href="https://aws.amazon.com/documentation/iam/">AWS
        /// Identity and Access Management User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerPolicy service method.</param>
        /// 
        /// <returns>The response from the GetContainerPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.PolicyNotFoundException">
        /// The policy that you specified in the request does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/GetContainerPolicy">REST API Reference for GetContainerPolicy Operation</seealso>
        public virtual GetContainerPolicyResponse GetContainerPolicy(GetContainerPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContainerPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerPolicyResponseUnmarshaller.Instance;

            return Invoke<GetContainerPolicyResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the access policy for the specified container. For information about the
        /// data that is included in an access policy, see the <a href="https://aws.amazon.com/documentation/iam/">AWS
        /// Identity and Access Management User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContainerPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.PolicyNotFoundException">
        /// The policy that you specified in the request does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/GetContainerPolicy">REST API Reference for GetContainerPolicy Operation</seealso>
        public virtual Task<GetContainerPolicyResponse> GetContainerPolicyAsync(GetContainerPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContainerPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetContainerPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCorsPolicy


        /// <summary>
        /// Returns the cross-origin resource sharing (CORS) configuration information that is
        /// set for the container.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <c>MediaStore:GetCorsPolicy</c>
        /// action. By default, the container owner has this permission and can grant it to others.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCorsPolicy service method.</param>
        /// 
        /// <returns>The response from the GetCorsPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.CorsPolicyNotFoundException">
        /// The CORS policy that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/GetCorsPolicy">REST API Reference for GetCorsPolicy Operation</seealso>
        public virtual GetCorsPolicyResponse GetCorsPolicy(GetCorsPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCorsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCorsPolicyResponseUnmarshaller.Instance;

            return Invoke<GetCorsPolicyResponse>(request, options);
        }


        /// <summary>
        /// Returns the cross-origin resource sharing (CORS) configuration information that is
        /// set for the container.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <c>MediaStore:GetCorsPolicy</c>
        /// action. By default, the container owner has this permission and can grant it to others.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCorsPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCorsPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.CorsPolicyNotFoundException">
        /// The CORS policy that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/GetCorsPolicy">REST API Reference for GetCorsPolicy Operation</seealso>
        public virtual Task<GetCorsPolicyResponse> GetCorsPolicyAsync(GetCorsPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCorsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCorsPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCorsPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLifecyclePolicy


        /// <summary>
        /// Retrieves the object lifecycle policy that is assigned to a container.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLifecyclePolicy service method.</param>
        /// 
        /// <returns>The response from the GetLifecyclePolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.PolicyNotFoundException">
        /// The policy that you specified in the request does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/GetLifecyclePolicy">REST API Reference for GetLifecyclePolicy Operation</seealso>
        public virtual GetLifecyclePolicyResponse GetLifecyclePolicy(GetLifecyclePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<GetLifecyclePolicyResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the object lifecycle policy that is assigned to a container.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLifecyclePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLifecyclePolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.PolicyNotFoundException">
        /// The policy that you specified in the request does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/GetLifecyclePolicy">REST API Reference for GetLifecyclePolicy Operation</seealso>
        public virtual Task<GetLifecyclePolicyResponse> GetLifecyclePolicyAsync(GetLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecyclePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLifecyclePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMetricPolicy


        /// <summary>
        /// Returns the metric policy for the specified container.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricPolicy service method.</param>
        /// 
        /// <returns>The response from the GetMetricPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.PolicyNotFoundException">
        /// The policy that you specified in the request does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/GetMetricPolicy">REST API Reference for GetMetricPolicy Operation</seealso>
        public virtual GetMetricPolicyResponse GetMetricPolicy(GetMetricPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMetricPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetricPolicyResponseUnmarshaller.Instance;

            return Invoke<GetMetricPolicyResponse>(request, options);
        }


        /// <summary>
        /// Returns the metric policy for the specified container.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMetricPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.PolicyNotFoundException">
        /// The policy that you specified in the request does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/GetMetricPolicy">REST API Reference for GetMetricPolicy Operation</seealso>
        public virtual Task<GetMetricPolicyResponse> GetMetricPolicyAsync(GetMetricPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMetricPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetricPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMetricPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListContainers


        /// <summary>
        /// Lists the properties of all containers in AWS Elemental MediaStore. 
        /// 
        ///  
        /// <para>
        /// You can query to receive all the containers in one response. Or you can include the
        /// <c>MaxResults</c> parameter to receive a limited number of containers in each response.
        /// In this case, the response includes a token. To get the next set of containers, send
        /// the command again, this time with the <c>NextToken</c> parameter (with the returned
        /// token as its value). The next set of responses appears, with a token if there are
        /// still more containers to receive. 
        /// </para>
        ///  
        /// <para>
        /// See also <a>DescribeContainer</a>, which gets the properties of one container. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContainers service method.</param>
        /// 
        /// <returns>The response from the ListContainers service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/ListContainers">REST API Reference for ListContainers Operation</seealso>
        public virtual ListContainersResponse ListContainers(ListContainersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContainersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContainersResponseUnmarshaller.Instance;

            return Invoke<ListContainersResponse>(request, options);
        }


        /// <summary>
        /// Lists the properties of all containers in AWS Elemental MediaStore. 
        /// 
        ///  
        /// <para>
        /// You can query to receive all the containers in one response. Or you can include the
        /// <c>MaxResults</c> parameter to receive a limited number of containers in each response.
        /// In this case, the response includes a token. To get the next set of containers, send
        /// the command again, this time with the <c>NextToken</c> parameter (with the returned
        /// token as its value). The next set of responses appears, with a token if there are
        /// still more containers to receive. 
        /// </para>
        ///  
        /// <para>
        /// See also <a>DescribeContainer</a>, which gets the properties of one container. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContainers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContainers service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/ListContainers">REST API Reference for ListContainers Operation</seealso>
        public virtual Task<ListContainersResponse> ListContainersAsync(ListContainersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContainersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContainersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListContainersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of the tags assigned to the specified container.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the tags assigned to the specified container.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutContainerPolicy


        /// <summary>
        /// Creates an access policy for the specified container to restrict the users and clients
        /// that can access it. For information about the data that is included in an access policy,
        /// see the <a href="https://aws.amazon.com/documentation/iam/">AWS Identity and Access
        /// Management User Guide</a>.
        /// 
        ///  
        /// <para>
        /// For this release of the REST API, you can create only one policy for a container.
        /// If you enter <c>PutContainerPolicy</c> twice, the second command modifies the existing
        /// policy. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutContainerPolicy service method.</param>
        /// 
        /// <returns>The response from the PutContainerPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/PutContainerPolicy">REST API Reference for PutContainerPolicy Operation</seealso>
        public virtual PutContainerPolicyResponse PutContainerPolicy(PutContainerPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutContainerPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutContainerPolicyResponseUnmarshaller.Instance;

            return Invoke<PutContainerPolicyResponse>(request, options);
        }


        /// <summary>
        /// Creates an access policy for the specified container to restrict the users and clients
        /// that can access it. For information about the data that is included in an access policy,
        /// see the <a href="https://aws.amazon.com/documentation/iam/">AWS Identity and Access
        /// Management User Guide</a>.
        /// 
        ///  
        /// <para>
        /// For this release of the REST API, you can create only one policy for a container.
        /// If you enter <c>PutContainerPolicy</c> twice, the second command modifies the existing
        /// policy. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutContainerPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutContainerPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/PutContainerPolicy">REST API Reference for PutContainerPolicy Operation</seealso>
        public virtual Task<PutContainerPolicyResponse> PutContainerPolicyAsync(PutContainerPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutContainerPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutContainerPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutContainerPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutCorsPolicy


        /// <summary>
        /// Sets the cross-origin resource sharing (CORS) configuration on a container so that
        /// the container can service cross-origin requests. For example, you might want to enable
        /// a request whose origin is http://www.example.com to access your AWS Elemental MediaStore
        /// container at my.example.container.com by using the browser's XMLHttpRequest capability.
        /// 
        ///  
        /// <para>
        /// To enable CORS on a container, you attach a CORS policy to the container. In the CORS
        /// policy, you configure rules that identify origins and the HTTP methods that can be
        /// executed on your container. The policy can contain up to 398,000 characters. You can
        /// add up to 100 rules to a CORS policy. If more than one rule applies, the service uses
        /// the first applicable rule listed.
        /// </para>
        ///  
        /// <para>
        /// To learn more about CORS, see <a href="https://docs.aws.amazon.com/mediastore/latest/ug/cors-policy.html">Cross-Origin
        /// Resource Sharing (CORS) in AWS Elemental MediaStore</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCorsPolicy service method.</param>
        /// 
        /// <returns>The response from the PutCorsPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/PutCorsPolicy">REST API Reference for PutCorsPolicy Operation</seealso>
        public virtual PutCorsPolicyResponse PutCorsPolicy(PutCorsPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutCorsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCorsPolicyResponseUnmarshaller.Instance;

            return Invoke<PutCorsPolicyResponse>(request, options);
        }


        /// <summary>
        /// Sets the cross-origin resource sharing (CORS) configuration on a container so that
        /// the container can service cross-origin requests. For example, you might want to enable
        /// a request whose origin is http://www.example.com to access your AWS Elemental MediaStore
        /// container at my.example.container.com by using the browser's XMLHttpRequest capability.
        /// 
        ///  
        /// <para>
        /// To enable CORS on a container, you attach a CORS policy to the container. In the CORS
        /// policy, you configure rules that identify origins and the HTTP methods that can be
        /// executed on your container. The policy can contain up to 398,000 characters. You can
        /// add up to 100 rules to a CORS policy. If more than one rule applies, the service uses
        /// the first applicable rule listed.
        /// </para>
        ///  
        /// <para>
        /// To learn more about CORS, see <a href="https://docs.aws.amazon.com/mediastore/latest/ug/cors-policy.html">Cross-Origin
        /// Resource Sharing (CORS) in AWS Elemental MediaStore</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCorsPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutCorsPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/PutCorsPolicy">REST API Reference for PutCorsPolicy Operation</seealso>
        public virtual Task<PutCorsPolicyResponse> PutCorsPolicyAsync(PutCorsPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutCorsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCorsPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutCorsPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutLifecyclePolicy


        /// <summary>
        /// Writes an object lifecycle policy to a container. If the container already has an
        /// object lifecycle policy, the service replaces the existing policy with the new policy.
        /// It takes up to 20 minutes for the change to take effect.
        /// 
        ///  
        /// <para>
        /// For information about how to construct an object lifecycle policy, see <a href="https://docs.aws.amazon.com/mediastore/latest/ug/policies-object-lifecycle-components.html">Components
        /// of an Object Lifecycle Policy</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLifecyclePolicy service method.</param>
        /// 
        /// <returns>The response from the PutLifecyclePolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/PutLifecyclePolicy">REST API Reference for PutLifecyclePolicy Operation</seealso>
        public virtual PutLifecyclePolicyResponse PutLifecyclePolicy(PutLifecyclePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<PutLifecyclePolicyResponse>(request, options);
        }


        /// <summary>
        /// Writes an object lifecycle policy to a container. If the container already has an
        /// object lifecycle policy, the service replaces the existing policy with the new policy.
        /// It takes up to 20 minutes for the change to take effect.
        /// 
        ///  
        /// <para>
        /// For information about how to construct an object lifecycle policy, see <a href="https://docs.aws.amazon.com/mediastore/latest/ug/policies-object-lifecycle-components.html">Components
        /// of an Object Lifecycle Policy</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLifecyclePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLifecyclePolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/PutLifecyclePolicy">REST API Reference for PutLifecyclePolicy Operation</seealso>
        public virtual Task<PutLifecyclePolicyResponse> PutLifecyclePolicyAsync(PutLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecyclePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutLifecyclePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutMetricPolicy


        /// <summary>
        /// The metric policy that you want to add to the container. A metric policy allows AWS
        /// Elemental MediaStore to send metrics to Amazon CloudWatch. It takes up to 20 minutes
        /// for the new policy to take effect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricPolicy service method.</param>
        /// 
        /// <returns>The response from the PutMetricPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/PutMetricPolicy">REST API Reference for PutMetricPolicy Operation</seealso>
        public virtual PutMetricPolicyResponse PutMetricPolicy(PutMetricPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMetricPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetricPolicyResponseUnmarshaller.Instance;

            return Invoke<PutMetricPolicyResponse>(request, options);
        }


        /// <summary>
        /// The metric policy that you want to add to the container. A metric policy allows AWS
        /// Elemental MediaStore to send metrics to Amazon CloudWatch. It takes up to 20 minutes
        /// for the new policy to take effect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutMetricPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/PutMetricPolicy">REST API Reference for PutMetricPolicy Operation</seealso>
        public virtual Task<PutMetricPolicyResponse> PutMetricPolicyAsync(PutMetricPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMetricPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetricPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutMetricPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartAccessLogging


        /// <summary>
        /// Starts access logging on the specified container. When you enable access logging on
        /// a container, MediaStore delivers access logs for objects stored in that container
        /// to Amazon CloudWatch Logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAccessLogging service method.</param>
        /// 
        /// <returns>The response from the StartAccessLogging service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/StartAccessLogging">REST API Reference for StartAccessLogging Operation</seealso>
        public virtual StartAccessLoggingResponse StartAccessLogging(StartAccessLoggingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAccessLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAccessLoggingResponseUnmarshaller.Instance;

            return Invoke<StartAccessLoggingResponse>(request, options);
        }


        /// <summary>
        /// Starts access logging on the specified container. When you enable access logging on
        /// a container, MediaStore delivers access logs for objects stored in that container
        /// to Amazon CloudWatch Logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAccessLogging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAccessLogging service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/StartAccessLogging">REST API Reference for StartAccessLogging Operation</seealso>
        public virtual Task<StartAccessLoggingResponse> StartAccessLoggingAsync(StartAccessLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAccessLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAccessLoggingResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartAccessLoggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopAccessLogging


        /// <summary>
        /// Stops access logging on the specified container. When you stop access logging on a
        /// container, MediaStore stops sending access logs to Amazon CloudWatch Logs. These access
        /// logs are not saved and are not retrievable.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAccessLogging service method.</param>
        /// 
        /// <returns>The response from the StopAccessLogging service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/StopAccessLogging">REST API Reference for StopAccessLogging Operation</seealso>
        public virtual StopAccessLoggingResponse StopAccessLogging(StopAccessLoggingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopAccessLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAccessLoggingResponseUnmarshaller.Instance;

            return Invoke<StopAccessLoggingResponse>(request, options);
        }


        /// <summary>
        /// Stops access logging on the specified container. When you stop access logging on a
        /// container, MediaStore stops sending access logs to Amazon CloudWatch Logs. These access
        /// logs are not saved and are not retrievable.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAccessLogging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopAccessLogging service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/StopAccessLogging">REST API Reference for StopAccessLogging Operation</seealso>
        public virtual Task<StopAccessLoggingResponse> StopAccessLoggingAsync(StopAccessLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopAccessLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAccessLoggingResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopAccessLoggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to the specified AWS Elemental MediaStore container. Tags are key:value
        /// pairs that you can associate with AWS resources. For example, the tag key might be
        /// "customer" and the tag value might be "companyA." You can specify one or more tags
        /// to add to each container. You can add up to 50 tags to each container. For more information
        /// about tagging, including naming and usage conventions, see <a href="https://docs.aws.amazon.com/mediastore/latest/ug/tagging.html">Tagging
        /// Resources in MediaStore</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds tags to the specified AWS Elemental MediaStore container. Tags are key:value
        /// pairs that you can associate with AWS resources. For example, the tag key might be
        /// "customer" and the tag value might be "companyA." You can specify one or more tags
        /// to add to each container. You can add up to 50 tags to each container. For more information
        /// about tagging, including naming and usage conventions, see <a href="https://docs.aws.amazon.com/mediastore/latest/ug/tagging.html">Tagging
        /// Resources in MediaStore</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from the specified container. You can specify one or more tags to remove.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from the specified container. You can specify one or more tags to remove.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// The container that you specified in the request already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// The container that you specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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