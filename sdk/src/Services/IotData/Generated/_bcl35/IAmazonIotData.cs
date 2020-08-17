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
 * Do not modify this file. This file is generated from the iot-data-2015-05-28.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IotData.Model;

namespace Amazon.IotData
{
    /// <summary>
    /// Interface for accessing IotData
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
    public partial interface IAmazonIotData : IAmazonService, IDisposable
    {

        
        #region  DeleteThingShadow


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
        DeleteThingShadowResponse DeleteThingShadow(DeleteThingShadowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteThingShadow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteThingShadow operation on AmazonIotDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteThingShadow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/DeleteThingShadow">REST API Reference for DeleteThingShadow Operation</seealso>
        IAsyncResult BeginDeleteThingShadow(DeleteThingShadowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteThingShadow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteThingShadow.</param>
        /// 
        /// <returns>Returns a  DeleteThingShadowResult from IotData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/DeleteThingShadow">REST API Reference for DeleteThingShadow Operation</seealso>
        DeleteThingShadowResponse EndDeleteThingShadow(IAsyncResult asyncResult);

        #endregion
        
        #region  GetThingShadow


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
        GetThingShadowResponse GetThingShadow(GetThingShadowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetThingShadow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetThingShadow operation on AmazonIotDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetThingShadow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/GetThingShadow">REST API Reference for GetThingShadow Operation</seealso>
        IAsyncResult BeginGetThingShadow(GetThingShadowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetThingShadow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetThingShadow.</param>
        /// 
        /// <returns>Returns a  GetThingShadowResult from IotData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/GetThingShadow">REST API Reference for GetThingShadow Operation</seealso>
        GetThingShadowResponse EndGetThingShadow(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNamedShadowsForThing


        /// <summary>
        /// Lists the shadows for the specified thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNamedShadowsForThing service method.</param>
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
        ListNamedShadowsForThingResponse ListNamedShadowsForThing(ListNamedShadowsForThingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNamedShadowsForThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNamedShadowsForThing operation on AmazonIotDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNamedShadowsForThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/ListNamedShadowsForThing">REST API Reference for ListNamedShadowsForThing Operation</seealso>
        IAsyncResult BeginListNamedShadowsForThing(ListNamedShadowsForThingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNamedShadowsForThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNamedShadowsForThing.</param>
        /// 
        /// <returns>Returns a  ListNamedShadowsForThingResult from IotData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/ListNamedShadowsForThing">REST API Reference for ListNamedShadowsForThing Operation</seealso>
        ListNamedShadowsForThingResponse EndListNamedShadowsForThing(IAsyncResult asyncResult);

        #endregion
        
        #region  Publish


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
        PublishResponse Publish(PublishRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Publish operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Publish operation on AmazonIotDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublish
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/Publish">REST API Reference for Publish Operation</seealso>
        IAsyncResult BeginPublish(PublishRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Publish operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublish.</param>
        /// 
        /// <returns>Returns a  PublishResult from IotData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/Publish">REST API Reference for Publish Operation</seealso>
        PublishResponse EndPublish(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateThingShadow


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
        UpdateThingShadowResponse UpdateThingShadow(UpdateThingShadowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateThingShadow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateThingShadow operation on AmazonIotDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateThingShadow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/UpdateThingShadow">REST API Reference for UpdateThingShadow Operation</seealso>
        IAsyncResult BeginUpdateThingShadow(UpdateThingShadowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateThingShadow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateThingShadow.</param>
        /// 
        /// <returns>Returns a  UpdateThingShadowResult from IotData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-data-2015-05-28/UpdateThingShadow">REST API Reference for UpdateThingShadow Operation</seealso>
        UpdateThingShadowResponse EndUpdateThingShadow(IAsyncResult asyncResult);

        #endregion
        
    }
}