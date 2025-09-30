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
 * Do not modify this file. This file is generated from the cloudfront-keyvaluestore-2022-07-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CloudFrontKeyValueStore.Model;
using Amazon.CloudFrontKeyValueStore.Model.Internal.MarshallTransformations;
using Amazon.CloudFrontKeyValueStore.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CloudFrontKeyValueStore
{
    /// <summary>
    /// <para>Implementation for accessing CloudFrontKeyValueStore</para>
    ///
    /// Amazon CloudFront KeyValueStore Service to View and Update Data in a KVS Resource
    /// </summary>
    public partial class AmazonCloudFrontKeyValueStoreClient : AmazonServiceClient, IAmazonCloudFrontKeyValueStore
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudFrontKeyValueStoreMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with the credentials loaded from the application's
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
        public AmazonCloudFrontKeyValueStoreClient()
            : base(new AmazonCloudFrontKeyValueStoreConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with the credentials loaded from the application's
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
        public AmazonCloudFrontKeyValueStoreClient(RegionEndpoint region)
            : base(new AmazonCloudFrontKeyValueStoreConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudFrontKeyValueStoreClient Configuration Object</param>
        public AmazonCloudFrontKeyValueStoreClient(AmazonCloudFrontKeyValueStoreConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudFrontKeyValueStoreClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudFrontKeyValueStoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFrontKeyValueStoreClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudFrontKeyValueStoreConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with AWS Credentials and an
        /// AmazonCloudFrontKeyValueStoreClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudFrontKeyValueStoreClient Configuration Object</param>
        public AmazonCloudFrontKeyValueStoreClient(AWSCredentials credentials, AmazonCloudFrontKeyValueStoreConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudFrontKeyValueStoreClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFrontKeyValueStoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFrontKeyValueStoreClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFrontKeyValueStoreConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFrontKeyValueStoreClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudFrontKeyValueStoreClient Configuration Object</param>
        public AmazonCloudFrontKeyValueStoreClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudFrontKeyValueStoreConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudFrontKeyValueStoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFrontKeyValueStoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFrontKeyValueStoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFrontKeyValueStoreConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontKeyValueStoreClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFrontKeyValueStoreClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudFrontKeyValueStoreClient Configuration Object</param>
        public AmazonCloudFrontKeyValueStoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudFrontKeyValueStoreConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ICloudFrontKeyValueStorePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICloudFrontKeyValueStorePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CloudFrontKeyValueStorePaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudFrontKeyValueStoreEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudFrontKeyValueStoreAuthSchemeHandler());
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


        #region  DeleteKey

        internal virtual DeleteKeyResponse DeleteKey(DeleteKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteKeyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the key value pair specified by the key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteKey service method, as returned by CloudFrontKeyValueStore.</returns>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ConflictException">
        /// Resource is not in expected state.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ServiceQuotaExceededException">
        /// Limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ValidationException">
        /// Validation failed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/DeleteKey">REST API Reference for DeleteKey Operation</seealso>
        public virtual Task<DeleteKeyResponse> DeleteKeyAsync(DeleteKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKeyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeKeyValueStore

        internal virtual DescribeKeyValueStoreResponse DescribeKeyValueStore(DescribeKeyValueStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeKeyValueStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyValueStoreResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyValueStoreResponse>(request, options);
        }



        /// <summary>
        /// Returns metadata information about Key Value Store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyValueStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKeyValueStore service method, as returned by CloudFrontKeyValueStore.</returns>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ConflictException">
        /// Resource is not in expected state.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/DescribeKeyValueStore">REST API Reference for DescribeKeyValueStore Operation</seealso>
        public virtual Task<DescribeKeyValueStoreResponse> DescribeKeyValueStoreAsync(DescribeKeyValueStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeKeyValueStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyValueStoreResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeKeyValueStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetKey

        internal virtual GetKeyResponse GetKey(GetKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyResponseUnmarshaller.Instance;

            return Invoke<GetKeyResponse>(request, options);
        }



        /// <summary>
        /// Returns a key value pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKey service method, as returned by CloudFrontKeyValueStore.</returns>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ConflictException">
        /// Resource is not in expected state.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/GetKey">REST API Reference for GetKey Operation</seealso>
        public virtual Task<GetKeyResponse> GetKeyAsync(GetKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyResponseUnmarshaller.Instance;

            return InvokeAsync<GetKeyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListKeys

        internal virtual ListKeysResponse ListKeys(ListKeysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeysResponseUnmarshaller.Instance;

            return Invoke<ListKeysResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of key value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKeys service method, as returned by CloudFrontKeyValueStore.</returns>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ConflictException">
        /// Resource is not in expected state.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ValidationException">
        /// Validation failed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/ListKeys">REST API Reference for ListKeys Operation</seealso>
        public virtual Task<ListKeysResponse> ListKeysAsync(ListKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListKeysResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutKey

        internal virtual PutKeyResponse PutKey(PutKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutKeyResponseUnmarshaller.Instance;

            return Invoke<PutKeyResponse>(request, options);
        }



        /// <summary>
        /// Creates a new key value pair or replaces the value of an existing key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutKey service method, as returned by CloudFrontKeyValueStore.</returns>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ConflictException">
        /// Resource is not in expected state.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ServiceQuotaExceededException">
        /// Limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ValidationException">
        /// Validation failed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/PutKey">REST API Reference for PutKey Operation</seealso>
        public virtual Task<PutKeyResponse> PutKeyAsync(PutKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutKeyResponseUnmarshaller.Instance;

            return InvokeAsync<PutKeyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateKeys

        internal virtual UpdateKeysResponse UpdateKeys(UpdateKeysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKeysResponseUnmarshaller.Instance;

            return Invoke<UpdateKeysResponse>(request, options);
        }



        /// <summary>
        /// Puts or Deletes multiple key value pairs in a single, all-or-nothing operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKeys service method, as returned by CloudFrontKeyValueStore.</returns>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ConflictException">
        /// Resource is not in expected state.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ServiceQuotaExceededException">
        /// Limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFrontKeyValueStore.Model.ValidationException">
        /// Validation failed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-keyvaluestore-2022-07-26/UpdateKeys">REST API Reference for UpdateKeys Operation</seealso>
        public virtual Task<UpdateKeysResponse> UpdateKeysAsync(UpdateKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKeysResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateKeysResponse>(request, options, cancellationToken);
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