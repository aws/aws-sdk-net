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
 * Do not modify this file. This file is generated from the mediastore-data-2017-09-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MediaStoreData.Model;
using Amazon.MediaStoreData.Model.Internal.MarshallTransformations;
using Amazon.MediaStoreData.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.MediaStoreData
{
    /// <summary>
    /// <para>Implementation for accessing MediaStoreData</para>
    ///
    /// An AWS Elemental MediaStore asset is an object, similar to an object in the Amazon
    /// S3 service. Objects are the fundamental entities that are stored in AWS Elemental
    /// MediaStore.
    /// </summary>
    public partial class AmazonMediaStoreDataClient : AmazonServiceClient, IAmazonMediaStoreData
    {
        private static IServiceMetadata serviceMetadata = new AmazonMediaStoreDataMetadata();
        
#if AWS_ASYNC_ENUMERABLES_API
        private IMediaStoreDataPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMediaStoreDataPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MediaStoreDataPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMediaStoreDataEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMediaStoreDataAuthSchemeHandler());
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


        #region  DeleteObject

        internal virtual DeleteObjectResponse DeleteObject(DeleteObjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectResponse>(request, options);
        }



        /// <summary>
        /// Deletes an object at the specified path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by MediaStoreData.</returns>
        /// <exception cref="Amazon.MediaStoreData.Model.ContainerNotFoundException">
        /// The specified container was not found for the specified account.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.ObjectNotFoundException">
        /// Could not perform an operation on an object that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-data-2017-09-01/DeleteObject">REST API Reference for DeleteObject Operation</seealso>
        public virtual Task<DeleteObjectResponse> DeleteObjectAsync(DeleteObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteObjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeObject

        internal virtual DescribeObjectResponse DescribeObject(DescribeObjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeObjectResponseUnmarshaller.Instance;

            return Invoke<DescribeObjectResponse>(request, options);
        }



        /// <summary>
        /// Gets the headers for an object at the specified path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeObject service method, as returned by MediaStoreData.</returns>
        /// <exception cref="Amazon.MediaStoreData.Model.ContainerNotFoundException">
        /// The specified container was not found for the specified account.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.ObjectNotFoundException">
        /// Could not perform an operation on an object that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-data-2017-09-01/DescribeObject">REST API Reference for DescribeObject Operation</seealso>
        public virtual Task<DescribeObjectResponse> DescribeObjectAsync(DescribeObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeObjectResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeObjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetObject

        internal virtual GetObjectResponse GetObject(GetObjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectResponseUnmarshaller.Instance;

            return Invoke<GetObjectResponse>(request, options);
        }



        /// <summary>
        /// Downloads the object at the specified path. If the object’s upload availability is
        /// set to <c>streaming</c>, AWS Elemental MediaStore downloads the object even if it’s
        /// still uploading the object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by MediaStoreData.</returns>
        /// <exception cref="Amazon.MediaStoreData.Model.ContainerNotFoundException">
        /// The specified container was not found for the specified account.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.ObjectNotFoundException">
        /// Could not perform an operation on an object that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.RequestedRangeNotSatisfiableException">
        /// The requested content range is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-data-2017-09-01/GetObject">REST API Reference for GetObject Operation</seealso>
        public virtual Task<GetObjectResponse> GetObjectAsync(GetObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListItems

        internal virtual ListItemsResponse ListItems(ListItemsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListItemsResponseUnmarshaller.Instance;

            return Invoke<ListItemsResponse>(request, options);
        }



        /// <summary>
        /// Provides a list of metadata entries about folders and objects in the specified folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListItems service method, as returned by MediaStoreData.</returns>
        /// <exception cref="Amazon.MediaStoreData.Model.ContainerNotFoundException">
        /// The specified container was not found for the specified account.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-data-2017-09-01/ListItems">REST API Reference for ListItems Operation</seealso>
        public virtual Task<ListItemsResponse> ListItemsAsync(ListItemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListItemsResponseUnmarshaller.Instance;

            return InvokeAsync<ListItemsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutObject

        internal virtual PutObjectResponse PutObject(PutObjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectResponseUnmarshaller.Instance;

            return Invoke<PutObjectResponse>(request, options);
        }



        /// <summary>
        /// Uploads an object to the specified path. Object sizes are limited to 25 MB for standard
        /// upload availability and 10 MB for streaming upload availability.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutObject service method, as returned by MediaStoreData.</returns>
        /// <exception cref="Amazon.MediaStoreData.Model.ContainerNotFoundException">
        /// The specified container was not found for the specified account.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-data-2017-09-01/PutObject">REST API Reference for PutObject Operation</seealso>
        public virtual Task<PutObjectResponse> PutObjectAsync(PutObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectResponseUnmarshaller.Instance;

            return InvokeAsync<PutObjectResponse>(request, options, cancellationToken);
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