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
 * Do not modify this file. This file is generated from the iotsecuretunneling-2018-10-05.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoTSecureTunneling.Model;

namespace Amazon.IoTSecureTunneling
{
    /// <summary>
    /// Interface for accessing IoTSecureTunneling
    ///
    /// AWS IoT Secure Tunneling 
    /// <para>
    /// AWS IoT Secure Tunnling enables you to create remote connections to devices deployed
    /// in the field.
    /// </para>
    ///  
    /// <para>
    /// For more information about how AWS IoT Secure Tunneling works, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/secure-tunneling.html">AWS
    /// IoT Secure Tunneling</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonIoTSecureTunneling : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIoTSecureTunnelingPaginatorFactory Paginators { get; }
#endif


        
        #region  CloseTunnel


        /// <summary>
        /// Closes a tunnel identified by the unique tunnel id. When a <code>CloseTunnel</code>
        /// request is received, we close the WebSocket connections between the client and proxy
        /// server so no data can be transmitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloseTunnel service method.</param>
        /// 
        /// <returns>The response from the CloseTunnel service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/CloseTunnel">REST API Reference for CloseTunnel Operation</seealso>
        CloseTunnelResponse CloseTunnel(CloseTunnelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CloseTunnel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CloseTunnel operation on AmazonIoTSecureTunnelingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCloseTunnel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/CloseTunnel">REST API Reference for CloseTunnel Operation</seealso>
        IAsyncResult BeginCloseTunnel(CloseTunnelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CloseTunnel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCloseTunnel.</param>
        /// 
        /// <returns>Returns a  CloseTunnelResult from IoTSecureTunneling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/CloseTunnel">REST API Reference for CloseTunnel Operation</seealso>
        CloseTunnelResponse EndCloseTunnel(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTunnel


        /// <summary>
        /// Gets information about a tunnel identified by the unique tunnel id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTunnel service method.</param>
        /// 
        /// <returns>The response from the DescribeTunnel service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/DescribeTunnel">REST API Reference for DescribeTunnel Operation</seealso>
        DescribeTunnelResponse DescribeTunnel(DescribeTunnelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTunnel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTunnel operation on AmazonIoTSecureTunnelingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTunnel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/DescribeTunnel">REST API Reference for DescribeTunnel Operation</seealso>
        IAsyncResult BeginDescribeTunnel(DescribeTunnelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTunnel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTunnel.</param>
        /// 
        /// <returns>Returns a  DescribeTunnelResult from IoTSecureTunneling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/DescribeTunnel">REST API Reference for DescribeTunnel Operation</seealso>
        DescribeTunnelResponse EndDescribeTunnel(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIoTSecureTunnelingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from IoTSecureTunneling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTunnels


        /// <summary>
        /// List all tunnels for an AWS account. Tunnels are listed by creation time in descending
        /// order, newer tunnels will be listed before older tunnels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTunnels service method.</param>
        /// 
        /// <returns>The response from the ListTunnels service method, as returned by IoTSecureTunneling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/ListTunnels">REST API Reference for ListTunnels Operation</seealso>
        ListTunnelsResponse ListTunnels(ListTunnelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTunnels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTunnels operation on AmazonIoTSecureTunnelingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTunnels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/ListTunnels">REST API Reference for ListTunnels Operation</seealso>
        IAsyncResult BeginListTunnels(ListTunnelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTunnels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTunnels.</param>
        /// 
        /// <returns>Returns a  ListTunnelsResult from IoTSecureTunneling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/ListTunnels">REST API Reference for ListTunnels Operation</seealso>
        ListTunnelsResponse EndListTunnels(IAsyncResult asyncResult);

        #endregion
        
        #region  OpenTunnel


        /// <summary>
        /// Creates a new tunnel, and returns two client access tokens for clients to use to connect
        /// to the AWS IoT Secure Tunneling proxy server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OpenTunnel service method.</param>
        /// 
        /// <returns>The response from the OpenTunnel service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.LimitExceededException">
        /// Thrown when a tunnel limit is exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/OpenTunnel">REST API Reference for OpenTunnel Operation</seealso>
        OpenTunnelResponse OpenTunnel(OpenTunnelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the OpenTunnel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the OpenTunnel operation on AmazonIoTSecureTunnelingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndOpenTunnel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/OpenTunnel">REST API Reference for OpenTunnel Operation</seealso>
        IAsyncResult BeginOpenTunnel(OpenTunnelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  OpenTunnel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginOpenTunnel.</param>
        /// 
        /// <returns>Returns a  OpenTunnelResult from IoTSecureTunneling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/OpenTunnel">REST API Reference for OpenTunnel Operation</seealso>
        OpenTunnelResponse EndOpenTunnel(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// A resource tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIoTSecureTunnelingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from IoTSecureTunneling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIoTSecureTunnelingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from IoTSecureTunneling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
    }
}