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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MediaPackage.Model;

namespace Amazon.MediaPackage
{
    /// <summary>
    /// Interface for accessing MediaPackage
    ///
    /// AWS Elemental MediaPackage
    /// </summary>
    public partial interface IAmazonMediaPackage : IAmazonService, IDisposable
    {

        
        #region  CreateChannel


        /// <summary>
        /// Creates a new Channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        CreateChannelResponse CreateChannel(CreateChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        IAsyncResult BeginCreateChannel(CreateChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannel.</param>
        /// 
        /// <returns>Returns a  CreateChannelResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        CreateChannelResponse EndCreateChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateOriginEndpoint


        /// <summary>
        /// Creates a new OriginEndpoint record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOriginEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateOriginEndpoint service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/CreateOriginEndpoint">REST API Reference for CreateOriginEndpoint Operation</seealso>
        CreateOriginEndpointResponse CreateOriginEndpoint(CreateOriginEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOriginEndpoint operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOriginEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/CreateOriginEndpoint">REST API Reference for CreateOriginEndpoint Operation</seealso>
        IAsyncResult BeginCreateOriginEndpoint(CreateOriginEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOriginEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateOriginEndpointResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/CreateOriginEndpoint">REST API Reference for CreateOriginEndpoint Operation</seealso>
        CreateOriginEndpointResponse EndCreateOriginEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteChannel


        /// <summary>
        /// Deletes an existing Channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        DeleteChannelResponse DeleteChannel(DeleteChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        IAsyncResult BeginDeleteChannel(DeleteChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannel.</param>
        /// 
        /// <returns>Returns a  DeleteChannelResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        DeleteChannelResponse EndDeleteChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteOriginEndpoint


        /// <summary>
        /// Deletes an existing OriginEndpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOriginEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteOriginEndpoint service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DeleteOriginEndpoint">REST API Reference for DeleteOriginEndpoint Operation</seealso>
        DeleteOriginEndpointResponse DeleteOriginEndpoint(DeleteOriginEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOriginEndpoint operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOriginEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DeleteOriginEndpoint">REST API Reference for DeleteOriginEndpoint Operation</seealso>
        IAsyncResult BeginDeleteOriginEndpoint(DeleteOriginEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOriginEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteOriginEndpointResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DeleteOriginEndpoint">REST API Reference for DeleteOriginEndpoint Operation</seealso>
        DeleteOriginEndpointResponse EndDeleteOriginEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeChannel


        /// <summary>
        /// Gets details about a Channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
        /// 
        /// <returns>The response from the DescribeChannel service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        DescribeChannelResponse DescribeChannel(DescribeChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        IAsyncResult BeginDescribeChannel(DescribeChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannel.</param>
        /// 
        /// <returns>Returns a  DescribeChannelResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        DescribeChannelResponse EndDescribeChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeOriginEndpoint


        /// <summary>
        /// Gets details about an existing OriginEndpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOriginEndpoint service method.</param>
        /// 
        /// <returns>The response from the DescribeOriginEndpoint service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DescribeOriginEndpoint">REST API Reference for DescribeOriginEndpoint Operation</seealso>
        DescribeOriginEndpointResponse DescribeOriginEndpoint(DescribeOriginEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOriginEndpoint operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOriginEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DescribeOriginEndpoint">REST API Reference for DescribeOriginEndpoint Operation</seealso>
        IAsyncResult BeginDescribeOriginEndpoint(DescribeOriginEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOriginEndpoint.</param>
        /// 
        /// <returns>Returns a  DescribeOriginEndpointResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DescribeOriginEndpoint">REST API Reference for DescribeOriginEndpoint Operation</seealso>
        DescribeOriginEndpointResponse EndDescribeOriginEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  ListChannels


        /// <summary>
        /// Returns a collection of Channels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/ListChannels">REST API Reference for ListChannels Operation</seealso>
        ListChannelsResponse ListChannels(ListChannelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannels operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/ListChannels">REST API Reference for ListChannels Operation</seealso>
        IAsyncResult BeginListChannels(ListChannelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannels.</param>
        /// 
        /// <returns>Returns a  ListChannelsResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/ListChannels">REST API Reference for ListChannels Operation</seealso>
        ListChannelsResponse EndListChannels(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOriginEndpoints


        /// <summary>
        /// Returns a collection of OriginEndpoint records.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOriginEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListOriginEndpoints service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/ListOriginEndpoints">REST API Reference for ListOriginEndpoints Operation</seealso>
        ListOriginEndpointsResponse ListOriginEndpoints(ListOriginEndpointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOriginEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOriginEndpoints operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOriginEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/ListOriginEndpoints">REST API Reference for ListOriginEndpoints Operation</seealso>
        IAsyncResult BeginListOriginEndpoints(ListOriginEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOriginEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOriginEndpoints.</param>
        /// 
        /// <returns>Returns a  ListOriginEndpointsResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/ListOriginEndpoints">REST API Reference for ListOriginEndpoints Operation</seealso>
        ListOriginEndpointsResponse EndListOriginEndpoints(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  RotateChannelCredentials


        /// <summary>
        /// Changes the Channel's first IngestEndpoint's username and password. WARNING - This
        /// API is deprecated. Please use RotateIngestEndpointCredentials instead
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RotateChannelCredentials service method.</param>
        /// 
        /// <returns>The response from the RotateChannelCredentials service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/RotateChannelCredentials">REST API Reference for RotateChannelCredentials Operation</seealso>
        [Obsolete("This API is deprecated. Please use RotateIngestEndpointCredentials instead")]
        RotateChannelCredentialsResponse RotateChannelCredentials(RotateChannelCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RotateChannelCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RotateChannelCredentials operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRotateChannelCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/RotateChannelCredentials">REST API Reference for RotateChannelCredentials Operation</seealso>
        [Obsolete("This API is deprecated. Please use RotateIngestEndpointCredentials instead")]
        IAsyncResult BeginRotateChannelCredentials(RotateChannelCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RotateChannelCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRotateChannelCredentials.</param>
        /// 
        /// <returns>Returns a  RotateChannelCredentialsResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/RotateChannelCredentials">REST API Reference for RotateChannelCredentials Operation</seealso>
        [Obsolete("This API is deprecated. Please use RotateIngestEndpointCredentials instead")]
        RotateChannelCredentialsResponse EndRotateChannelCredentials(IAsyncResult asyncResult);

        #endregion
        
        #region  RotateIngestEndpointCredentials


        /// <summary>
        /// Rotate the IngestEndpoint's username and password, as specified by the IngestEndpoint's
        /// id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RotateIngestEndpointCredentials service method.</param>
        /// 
        /// <returns>The response from the RotateIngestEndpointCredentials service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/RotateIngestEndpointCredentials">REST API Reference for RotateIngestEndpointCredentials Operation</seealso>
        RotateIngestEndpointCredentialsResponse RotateIngestEndpointCredentials(RotateIngestEndpointCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RotateIngestEndpointCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RotateIngestEndpointCredentials operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRotateIngestEndpointCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/RotateIngestEndpointCredentials">REST API Reference for RotateIngestEndpointCredentials Operation</seealso>
        IAsyncResult BeginRotateIngestEndpointCredentials(RotateIngestEndpointCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RotateIngestEndpointCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRotateIngestEndpointCredentials.</param>
        /// 
        /// <returns>Returns a  RotateIngestEndpointCredentialsResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/RotateIngestEndpointCredentials">REST API Reference for RotateIngestEndpointCredentials Operation</seealso>
        RotateIngestEndpointCredentialsResponse EndRotateIngestEndpointCredentials(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateChannel


        /// <summary>
        /// Updates an existing Channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        UpdateChannelResponse UpdateChannel(UpdateChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        IAsyncResult BeginUpdateChannel(UpdateChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannel.</param>
        /// 
        /// <returns>Returns a  UpdateChannelResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        UpdateChannelResponse EndUpdateChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateOriginEndpoint


        /// <summary>
        /// Updates an existing OriginEndpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOriginEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateOriginEndpoint service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/UpdateOriginEndpoint">REST API Reference for UpdateOriginEndpoint Operation</seealso>
        UpdateOriginEndpointResponse UpdateOriginEndpoint(UpdateOriginEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOriginEndpoint operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOriginEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/UpdateOriginEndpoint">REST API Reference for UpdateOriginEndpoint Operation</seealso>
        IAsyncResult BeginUpdateOriginEndpoint(UpdateOriginEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOriginEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateOriginEndpointResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/UpdateOriginEndpoint">REST API Reference for UpdateOriginEndpoint Operation</seealso>
        UpdateOriginEndpointResponse EndUpdateOriginEndpoint(IAsyncResult asyncResult);

        #endregion
        
    }
}