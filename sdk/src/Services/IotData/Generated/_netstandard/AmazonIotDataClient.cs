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
 * Do not modify this file. This file is generated from the iot-data-2015-05-28.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.IotData.Model;
using Amazon.IotData.Model.Internal.MarshallTransformations;
using Amazon.IotData.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IotData
{
    /// <summary>
    /// Implementation for accessing IotData
    ///
    /// AWS IoT 
    /// <para>
    /// AWS IoT-Data enables secure, bi-directional communication between Internet-connected
    /// things (such as sensors, actuators, embedded devices, or smart appliances) and the
    /// AWS cloud. It implements a broker for applications and things to publish messages
    /// over HTTP (Publish) and retrieve, update, and delete shadows. A shadow is a persistent
    /// representation of your things and their state in the AWS cloud.
    /// </para>
    ///  
    /// <para>
    /// Find the endpoint address for actions in the AWS IoT data plane by running this CLI
    /// command:
    /// </para>
    ///  
    /// <para>
    ///  <code>aws iot describe-endpoint --endpoint-type iot:Data-ATS</code> 
    /// </para>
    ///  
    /// <para>
    /// The service name used by <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">AWS
    /// Signature Version 4</a> to sign requests is: <i>iotdevicegateway</i>.
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonIotDataClient : AmazonServiceClient, IAmazonIotData
    {
        private static IServiceMetadata serviceMetadata = new AmazonIotDataMetadata();
        

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


        #region  DeleteThingShadow

        internal virtual DeleteThingShadowResponse DeleteThingShadow(DeleteThingShadowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThingShadowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThingShadowResponseUnmarshaller.Instance;

            return Invoke<DeleteThingShadowResponse>(request, options);
        }



        /// <summary>
        /// Deletes the shadow for the specified thing.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/iot/latest/developerguide/API_DeleteThingShadow.html">DeleteThingShadow</a>
        /// in the AWS IoT Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThingShadow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteThingShadow service method, as returned by IotData.</returns>
        /// <exception cref="Amazon.IotData.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.MethodNotAllowedException">
        /// The specified combination of HTTP verb and URI is not supported.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnsupportedDocumentEncodingException">
        /// The document encoding is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/DeleteThingShadow">REST API Reference for DeleteThingShadow Operation</seealso>
        public virtual Task<DeleteThingShadowResponse> DeleteThingShadowAsync(DeleteThingShadowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThingShadowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThingShadowResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteThingShadowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetThingShadow

        internal virtual GetThingShadowResponse GetThingShadow(GetThingShadowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetThingShadowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetThingShadowResponseUnmarshaller.Instance;

            return Invoke<GetThingShadowResponse>(request, options);
        }



        /// <summary>
        /// Gets the shadow for the specified thing.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/iot/latest/developerguide/API_GetThingShadow.html">GetThingShadow</a>
        /// in the AWS IoT Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetThingShadow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetThingShadow service method, as returned by IotData.</returns>
        /// <exception cref="Amazon.IotData.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.MethodNotAllowedException">
        /// The specified combination of HTTP verb and URI is not supported.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnsupportedDocumentEncodingException">
        /// The document encoding is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/GetThingShadow">REST API Reference for GetThingShadow Operation</seealso>
        public virtual Task<GetThingShadowResponse> GetThingShadowAsync(GetThingShadowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetThingShadowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetThingShadowResponseUnmarshaller.Instance;

            return InvokeAsync<GetThingShadowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNamedShadowsForThing

        internal virtual ListNamedShadowsForThingResponse ListNamedShadowsForThing(ListNamedShadowsForThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNamedShadowsForThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamedShadowsForThingResponseUnmarshaller.Instance;

            return Invoke<ListNamedShadowsForThingResponse>(request, options);
        }



        /// <summary>
        /// Lists the shadows for the specified thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNamedShadowsForThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNamedShadowsForThing service method, as returned by IotData.</returns>
        /// <exception cref="Amazon.IotData.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.MethodNotAllowedException">
        /// The specified combination of HTTP verb and URI is not supported.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/ListNamedShadowsForThing">REST API Reference for ListNamedShadowsForThing Operation</seealso>
        public virtual Task<ListNamedShadowsForThingResponse> ListNamedShadowsForThingAsync(ListNamedShadowsForThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNamedShadowsForThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamedShadowsForThingResponseUnmarshaller.Instance;

            return InvokeAsync<ListNamedShadowsForThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Publish

        internal virtual PublishResponse Publish(PublishRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishResponseUnmarshaller.Instance;

            return Invoke<PublishResponse>(request, options);
        }



        /// <summary>
        /// Publishes state information.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/iot/latest/developerguide/protocols.html#http">HTTP
        /// Protocol</a> in the AWS IoT Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Publish service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Publish service method, as returned by IotData.</returns>
        /// <exception cref="Amazon.IotData.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.MethodNotAllowedException">
        /// The specified combination of HTTP verb and URI is not supported.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/Publish">REST API Reference for Publish Operation</seealso>
        public virtual Task<PublishResponse> PublishAsync(PublishRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishResponseUnmarshaller.Instance;

            return InvokeAsync<PublishResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateThingShadow

        internal virtual UpdateThingShadowResponse UpdateThingShadow(UpdateThingShadowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThingShadowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThingShadowResponseUnmarshaller.Instance;

            return Invoke<UpdateThingShadowResponse>(request, options);
        }



        /// <summary>
        /// Updates the shadow for the specified thing.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/iot/latest/developerguide/API_UpdateThingShadow.html">UpdateThingShadow</a>
        /// in the AWS IoT Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThingShadow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateThingShadow service method, as returned by IotData.</returns>
        /// <exception cref="Amazon.IotData.Model.ConflictException">
        /// The specified version does not match the version of the document.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.MethodNotAllowedException">
        /// The specified combination of HTTP verb and URI is not supported.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.RequestEntityTooLargeException">
        /// The payload exceeds the maximum size allowed.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnsupportedDocumentEncodingException">
        /// The document encoding is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/UpdateThingShadow">REST API Reference for UpdateThingShadow Operation</seealso>
        public virtual Task<UpdateThingShadowResponse> UpdateThingShadowAsync(UpdateThingShadowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThingShadowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThingShadowResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateThingShadowResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}