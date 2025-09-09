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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MediaPackageV2.Model;

#pragma warning disable CS1570
namespace Amazon.MediaPackageV2
{
    /// <summary>
    /// <para>Interface for accessing MediaPackageV2</para>
    ///
    /// <note> 
    /// <para>
    /// This guide is intended for creating AWS Elemental MediaPackage resources in MediaPackage
    /// Version 2 (v2) starting from May 2023. To get started with MediaPackage v2, create
    /// your MediaPackage resources. There isn't an automated process to migrate your resources
    /// from MediaPackage v1 to MediaPackage v2. 
    /// 
    ///  
    /// <para>
    /// The names of the entities that you use to access this API, like URLs and ARNs, all
    /// have the versioning information added, like &quot;v2&quot;, to distinguish from the
    /// prior version. If you used MediaPackage prior to this release, you can't use the MediaPackage
    /// v2 CLI or the MediaPackage v2 API to access any MediaPackage v1 resources.
    /// </para>
    ///  
    /// <para>
    /// If you created resources in MediaPackage v1, use video on demand (VOD) workflows,
    /// and aren't looking to migrate to MediaPackage v2 yet, see the <a href="https://docs.aws.amazon.com/mediapackage/latest/apireference/what-is.html">MediaPackage
    /// v1 Live API Reference</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// This is the AWS Elemental MediaPackage v2 Live REST API Reference. It describes all
    /// the MediaPackage API operations for live content in detail, and provides sample requests,
    /// responses, and errors for the supported web services protocols.
    /// </para>
    ///  
    /// <para>
    /// We assume that you have the IAM permissions that you need to use MediaPackage via
    /// the REST API. We also assume that you are familiar with the features and operations
    /// of MediaPackage, as described in the AWS Elemental MediaPackage User Guide.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonMediaPackageV2 : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMediaPackageV2PaginatorFactory Paginators { get; }
#endif


        
        #region  CancelHarvestJob


        /// <summary>
        /// Cancels an in-progress harvest job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelHarvestJob service method.</param>
        /// 
        /// <returns>The response from the CancelHarvestJob service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CancelHarvestJob">REST API Reference for CancelHarvestJob Operation</seealso>
        CancelHarvestJobResponse CancelHarvestJob(CancelHarvestJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelHarvestJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelHarvestJob operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelHarvestJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CancelHarvestJob">REST API Reference for CancelHarvestJob Operation</seealso>
        IAsyncResult BeginCancelHarvestJob(CancelHarvestJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelHarvestJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelHarvestJob.</param>
        /// 
        /// <returns>Returns a  CancelHarvestJobResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CancelHarvestJob">REST API Reference for CancelHarvestJob Operation</seealso>
        CancelHarvestJobResponse EndCancelHarvestJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateChannel


        /// <summary>
        /// Create a channel to start receiving content streams. The channel represents the input
        /// to MediaPackage for incoming live content from an encoder such as AWS Elemental MediaLive.
        /// The channel receives content, and after packaging it, outputs it through an origin
        /// endpoint to downstream devices (such as video players or CDNs) that request the content.
        /// You can create only one channel with each request. We recommend that you spread out
        /// channels between channel groups, such as putting redundant channels in the same AWS
        /// Region in different channel groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        CreateChannelResponse CreateChannel(CreateChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        IAsyncResult BeginCreateChannel(CreateChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannel.</param>
        /// 
        /// <returns>Returns a  CreateChannelResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        CreateChannelResponse EndCreateChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateChannelGroup


        /// <summary>
        /// Create a channel group to group your channels and origin endpoints. A channel group
        /// is the top-level resource that consists of channels and origin endpoints that are
        /// associated with it and that provides predictable URLs for stream delivery. All channels
        /// and origin endpoints within the channel group are guaranteed to share the DNS. You
        /// can create only one channel group with each request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelGroup service method.</param>
        /// 
        /// <returns>The response from the CreateChannelGroup service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CreateChannelGroup">REST API Reference for CreateChannelGroup Operation</seealso>
        CreateChannelGroupResponse CreateChannelGroup(CreateChannelGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannelGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelGroup operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannelGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CreateChannelGroup">REST API Reference for CreateChannelGroup Operation</seealso>
        IAsyncResult BeginCreateChannelGroup(CreateChannelGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannelGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannelGroup.</param>
        /// 
        /// <returns>Returns a  CreateChannelGroupResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CreateChannelGroup">REST API Reference for CreateChannelGroup Operation</seealso>
        CreateChannelGroupResponse EndCreateChannelGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateHarvestJob


        /// <summary>
        /// Creates a new harvest job to export content from a MediaPackage v2 channel to an S3
        /// bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHarvestJob service method.</param>
        /// 
        /// <returns>The response from the CreateHarvestJob service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CreateHarvestJob">REST API Reference for CreateHarvestJob Operation</seealso>
        CreateHarvestJobResponse CreateHarvestJob(CreateHarvestJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHarvestJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHarvestJob operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHarvestJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CreateHarvestJob">REST API Reference for CreateHarvestJob Operation</seealso>
        IAsyncResult BeginCreateHarvestJob(CreateHarvestJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHarvestJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHarvestJob.</param>
        /// 
        /// <returns>Returns a  CreateHarvestJobResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CreateHarvestJob">REST API Reference for CreateHarvestJob Operation</seealso>
        CreateHarvestJobResponse EndCreateHarvestJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateOriginEndpoint


        /// <summary>
        /// The endpoint is attached to a channel, and represents the output of the live content.
        /// You can associate multiple endpoints to a single channel. Each endpoint gives players
        /// and downstream CDNs (such as Amazon CloudFront) access to the content for playback.
        /// Content can't be served from a channel until it has an endpoint. You can create only
        /// one endpoint with each request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOriginEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateOriginEndpoint service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CreateOriginEndpoint">REST API Reference for CreateOriginEndpoint Operation</seealso>
        CreateOriginEndpointResponse CreateOriginEndpoint(CreateOriginEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOriginEndpoint operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOriginEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CreateOriginEndpoint">REST API Reference for CreateOriginEndpoint Operation</seealso>
        IAsyncResult BeginCreateOriginEndpoint(CreateOriginEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOriginEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateOriginEndpointResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CreateOriginEndpoint">REST API Reference for CreateOriginEndpoint Operation</seealso>
        CreateOriginEndpointResponse EndCreateOriginEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteChannel


        /// <summary>
        /// Delete a channel to stop AWS Elemental MediaPackage from receiving further content.
        /// You must delete the channel's origin endpoints before you can delete the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        DeleteChannelResponse DeleteChannel(DeleteChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        IAsyncResult BeginDeleteChannel(DeleteChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannel.</param>
        /// 
        /// <returns>Returns a  DeleteChannelResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        DeleteChannelResponse EndDeleteChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteChannelGroup


        /// <summary>
        /// Delete a channel group. You must delete the channel group's channels and origin endpoints
        /// before you can delete the channel group. If you delete a channel group, you'll lose
        /// access to the egress domain and will have to create a new channel group to replace
        /// it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteChannelGroup service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteChannelGroup">REST API Reference for DeleteChannelGroup Operation</seealso>
        DeleteChannelGroupResponse DeleteChannelGroup(DeleteChannelGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannelGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelGroup operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannelGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteChannelGroup">REST API Reference for DeleteChannelGroup Operation</seealso>
        IAsyncResult BeginDeleteChannelGroup(DeleteChannelGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannelGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannelGroup.</param>
        /// 
        /// <returns>Returns a  DeleteChannelGroupResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteChannelGroup">REST API Reference for DeleteChannelGroup Operation</seealso>
        DeleteChannelGroupResponse EndDeleteChannelGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteChannelPolicy


        /// <summary>
        /// Delete a channel policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteChannelPolicy service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteChannelPolicy">REST API Reference for DeleteChannelPolicy Operation</seealso>
        DeleteChannelPolicyResponse DeleteChannelPolicy(DeleteChannelPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannelPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelPolicy operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannelPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteChannelPolicy">REST API Reference for DeleteChannelPolicy Operation</seealso>
        IAsyncResult BeginDeleteChannelPolicy(DeleteChannelPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannelPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannelPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteChannelPolicyResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteChannelPolicy">REST API Reference for DeleteChannelPolicy Operation</seealso>
        DeleteChannelPolicyResponse EndDeleteChannelPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteOriginEndpoint


        /// <summary>
        /// Origin endpoints can serve content until they're deleted. Delete the endpoint if it
        /// should no longer respond to playback requests. You must delete all endpoints from
        /// a channel before you can delete the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOriginEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteOriginEndpoint service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteOriginEndpoint">REST API Reference for DeleteOriginEndpoint Operation</seealso>
        DeleteOriginEndpointResponse DeleteOriginEndpoint(DeleteOriginEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOriginEndpoint operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOriginEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteOriginEndpoint">REST API Reference for DeleteOriginEndpoint Operation</seealso>
        IAsyncResult BeginDeleteOriginEndpoint(DeleteOriginEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOriginEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteOriginEndpointResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteOriginEndpoint">REST API Reference for DeleteOriginEndpoint Operation</seealso>
        DeleteOriginEndpointResponse EndDeleteOriginEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteOriginEndpointPolicy


        /// <summary>
        /// Delete an origin endpoint policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOriginEndpointPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteOriginEndpointPolicy service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteOriginEndpointPolicy">REST API Reference for DeleteOriginEndpointPolicy Operation</seealso>
        DeleteOriginEndpointPolicyResponse DeleteOriginEndpointPolicy(DeleteOriginEndpointPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOriginEndpointPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOriginEndpointPolicy operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOriginEndpointPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteOriginEndpointPolicy">REST API Reference for DeleteOriginEndpointPolicy Operation</seealso>
        IAsyncResult BeginDeleteOriginEndpointPolicy(DeleteOriginEndpointPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOriginEndpointPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOriginEndpointPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteOriginEndpointPolicyResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteOriginEndpointPolicy">REST API Reference for DeleteOriginEndpointPolicy Operation</seealso>
        DeleteOriginEndpointPolicyResponse EndDeleteOriginEndpointPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetChannel


        /// <summary>
        /// Retrieves the specified channel that's configured in AWS Elemental MediaPackage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannel service method.</param>
        /// 
        /// <returns>The response from the GetChannel service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetChannel">REST API Reference for GetChannel Operation</seealso>
        GetChannelResponse GetChannel(GetChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChannel operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetChannel">REST API Reference for GetChannel Operation</seealso>
        IAsyncResult BeginGetChannel(GetChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChannel.</param>
        /// 
        /// <returns>Returns a  GetChannelResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetChannel">REST API Reference for GetChannel Operation</seealso>
        GetChannelResponse EndGetChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetChannelGroup


        /// <summary>
        /// Retrieves the specified channel group that's configured in AWS Elemental MediaPackage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelGroup service method.</param>
        /// 
        /// <returns>The response from the GetChannelGroup service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetChannelGroup">REST API Reference for GetChannelGroup Operation</seealso>
        GetChannelGroupResponse GetChannelGroup(GetChannelGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetChannelGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChannelGroup operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChannelGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetChannelGroup">REST API Reference for GetChannelGroup Operation</seealso>
        IAsyncResult BeginGetChannelGroup(GetChannelGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetChannelGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChannelGroup.</param>
        /// 
        /// <returns>Returns a  GetChannelGroupResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetChannelGroup">REST API Reference for GetChannelGroup Operation</seealso>
        GetChannelGroupResponse EndGetChannelGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetChannelPolicy


        /// <summary>
        /// Retrieves the specified channel policy that's configured in AWS Elemental MediaPackage.
        /// With policies, you can specify who has access to AWS resources and what actions they
        /// can perform on those resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelPolicy service method.</param>
        /// 
        /// <returns>The response from the GetChannelPolicy service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetChannelPolicy">REST API Reference for GetChannelPolicy Operation</seealso>
        GetChannelPolicyResponse GetChannelPolicy(GetChannelPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetChannelPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChannelPolicy operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChannelPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetChannelPolicy">REST API Reference for GetChannelPolicy Operation</seealso>
        IAsyncResult BeginGetChannelPolicy(GetChannelPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetChannelPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChannelPolicy.</param>
        /// 
        /// <returns>Returns a  GetChannelPolicyResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetChannelPolicy">REST API Reference for GetChannelPolicy Operation</seealso>
        GetChannelPolicyResponse EndGetChannelPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetHarvestJob


        /// <summary>
        /// Retrieves the details of a specific harvest job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHarvestJob service method.</param>
        /// 
        /// <returns>The response from the GetHarvestJob service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetHarvestJob">REST API Reference for GetHarvestJob Operation</seealso>
        GetHarvestJobResponse GetHarvestJob(GetHarvestJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHarvestJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHarvestJob operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHarvestJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetHarvestJob">REST API Reference for GetHarvestJob Operation</seealso>
        IAsyncResult BeginGetHarvestJob(GetHarvestJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetHarvestJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHarvestJob.</param>
        /// 
        /// <returns>Returns a  GetHarvestJobResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetHarvestJob">REST API Reference for GetHarvestJob Operation</seealso>
        GetHarvestJobResponse EndGetHarvestJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOriginEndpoint


        /// <summary>
        /// Retrieves the specified origin endpoint that's configured in AWS Elemental MediaPackage
        /// to obtain its playback URL and to view the packaging settings that it's currently
        /// using.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOriginEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetOriginEndpoint service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetOriginEndpoint">REST API Reference for GetOriginEndpoint Operation</seealso>
        GetOriginEndpointResponse GetOriginEndpoint(GetOriginEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOriginEndpoint operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOriginEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetOriginEndpoint">REST API Reference for GetOriginEndpoint Operation</seealso>
        IAsyncResult BeginGetOriginEndpoint(GetOriginEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOriginEndpoint.</param>
        /// 
        /// <returns>Returns a  GetOriginEndpointResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetOriginEndpoint">REST API Reference for GetOriginEndpoint Operation</seealso>
        GetOriginEndpointResponse EndGetOriginEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOriginEndpointPolicy


        /// <summary>
        /// Retrieves the specified origin endpoint policy that's configured in AWS Elemental
        /// MediaPackage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOriginEndpointPolicy service method.</param>
        /// 
        /// <returns>The response from the GetOriginEndpointPolicy service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetOriginEndpointPolicy">REST API Reference for GetOriginEndpointPolicy Operation</seealso>
        GetOriginEndpointPolicyResponse GetOriginEndpointPolicy(GetOriginEndpointPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOriginEndpointPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOriginEndpointPolicy operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOriginEndpointPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetOriginEndpointPolicy">REST API Reference for GetOriginEndpointPolicy Operation</seealso>
        IAsyncResult BeginGetOriginEndpointPolicy(GetOriginEndpointPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOriginEndpointPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOriginEndpointPolicy.</param>
        /// 
        /// <returns>Returns a  GetOriginEndpointPolicyResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetOriginEndpointPolicy">REST API Reference for GetOriginEndpointPolicy Operation</seealso>
        GetOriginEndpointPolicyResponse EndGetOriginEndpointPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  ListChannelGroups


        /// <summary>
        /// Retrieves all channel groups that are configured in Elemental MediaPackage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelGroups service method.</param>
        /// 
        /// <returns>The response from the ListChannelGroups service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListChannelGroups">REST API Reference for ListChannelGroups Operation</seealso>
        ListChannelGroupsResponse ListChannelGroups(ListChannelGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelGroups operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListChannelGroups">REST API Reference for ListChannelGroups Operation</seealso>
        IAsyncResult BeginListChannelGroups(ListChannelGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelGroups.</param>
        /// 
        /// <returns>Returns a  ListChannelGroupsResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListChannelGroups">REST API Reference for ListChannelGroups Operation</seealso>
        ListChannelGroupsResponse EndListChannelGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListChannels


        /// <summary>
        /// Retrieves all channels in a specific channel group that are configured in AWS Elemental
        /// MediaPackage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListChannels">REST API Reference for ListChannels Operation</seealso>
        ListChannelsResponse ListChannels(ListChannelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannels operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListChannels">REST API Reference for ListChannels Operation</seealso>
        IAsyncResult BeginListChannels(ListChannelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannels.</param>
        /// 
        /// <returns>Returns a  ListChannelsResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListChannels">REST API Reference for ListChannels Operation</seealso>
        ListChannelsResponse EndListChannels(IAsyncResult asyncResult);

        #endregion
        
        #region  ListHarvestJobs


        /// <summary>
        /// Retrieves a list of harvest jobs that match the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHarvestJobs service method.</param>
        /// 
        /// <returns>The response from the ListHarvestJobs service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListHarvestJobs">REST API Reference for ListHarvestJobs Operation</seealso>
        ListHarvestJobsResponse ListHarvestJobs(ListHarvestJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHarvestJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHarvestJobs operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHarvestJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListHarvestJobs">REST API Reference for ListHarvestJobs Operation</seealso>
        IAsyncResult BeginListHarvestJobs(ListHarvestJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListHarvestJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHarvestJobs.</param>
        /// 
        /// <returns>Returns a  ListHarvestJobsResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListHarvestJobs">REST API Reference for ListHarvestJobs Operation</seealso>
        ListHarvestJobsResponse EndListHarvestJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOriginEndpoints


        /// <summary>
        /// Retrieves all origin endpoints in a specific channel that are configured in AWS Elemental
        /// MediaPackage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOriginEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListOriginEndpoints service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListOriginEndpoints">REST API Reference for ListOriginEndpoints Operation</seealso>
        ListOriginEndpointsResponse ListOriginEndpoints(ListOriginEndpointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOriginEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOriginEndpoints operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOriginEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListOriginEndpoints">REST API Reference for ListOriginEndpoints Operation</seealso>
        IAsyncResult BeginListOriginEndpoints(ListOriginEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOriginEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOriginEndpoints.</param>
        /// 
        /// <returns>Returns a  ListOriginEndpointsResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListOriginEndpoints">REST API Reference for ListOriginEndpoints Operation</seealso>
        ListOriginEndpointsResponse EndListOriginEndpoints(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags assigned to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutChannelPolicy


        /// <summary>
        /// Attaches an IAM policy to the specified channel. With policies, you can specify who
        /// has access to AWS resources and what actions they can perform on those resources.
        /// You can attach only one policy with each request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutChannelPolicy service method.</param>
        /// 
        /// <returns>The response from the PutChannelPolicy service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/PutChannelPolicy">REST API Reference for PutChannelPolicy Operation</seealso>
        PutChannelPolicyResponse PutChannelPolicy(PutChannelPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutChannelPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutChannelPolicy operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutChannelPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/PutChannelPolicy">REST API Reference for PutChannelPolicy Operation</seealso>
        IAsyncResult BeginPutChannelPolicy(PutChannelPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutChannelPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutChannelPolicy.</param>
        /// 
        /// <returns>Returns a  PutChannelPolicyResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/PutChannelPolicy">REST API Reference for PutChannelPolicy Operation</seealso>
        PutChannelPolicyResponse EndPutChannelPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  PutOriginEndpointPolicy


        /// <summary>
        /// Attaches an IAM policy to the specified origin endpoint. You can attach only one policy
        /// with each request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOriginEndpointPolicy service method.</param>
        /// 
        /// <returns>The response from the PutOriginEndpointPolicy service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/PutOriginEndpointPolicy">REST API Reference for PutOriginEndpointPolicy Operation</seealso>
        PutOriginEndpointPolicyResponse PutOriginEndpointPolicy(PutOriginEndpointPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutOriginEndpointPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutOriginEndpointPolicy operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutOriginEndpointPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/PutOriginEndpointPolicy">REST API Reference for PutOriginEndpointPolicy Operation</seealso>
        IAsyncResult BeginPutOriginEndpointPolicy(PutOriginEndpointPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutOriginEndpointPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutOriginEndpointPolicy.</param>
        /// 
        /// <returns>Returns a  PutOriginEndpointPolicyResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/PutOriginEndpointPolicy">REST API Reference for PutOriginEndpointPolicy Operation</seealso>
        PutOriginEndpointPolicyResponse EndPutOriginEndpointPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetChannelState


        /// <summary>
        /// Resetting the channel can help to clear errors from misconfigurations in the encoder.
        /// A reset refreshes the ingest stream and removes previous content. 
        /// 
        ///  
        /// <para>
        ///  Be sure to stop the encoder before you reset the channel, and wait at least 30 seconds
        /// before you restart the encoder. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetChannelState service method.</param>
        /// 
        /// <returns>The response from the ResetChannelState service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ResetChannelState">REST API Reference for ResetChannelState Operation</seealso>
        ResetChannelStateResponse ResetChannelState(ResetChannelStateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetChannelState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetChannelState operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetChannelState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ResetChannelState">REST API Reference for ResetChannelState Operation</seealso>
        IAsyncResult BeginResetChannelState(ResetChannelStateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetChannelState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetChannelState.</param>
        /// 
        /// <returns>Returns a  ResetChannelStateResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ResetChannelState">REST API Reference for ResetChannelState Operation</seealso>
        ResetChannelStateResponse EndResetChannelState(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetOriginEndpointState


        /// <summary>
        /// Resetting the origin endpoint can help to resolve unexpected behavior and other content
        /// packaging issues. It also helps to preserve special events when you don't want the
        /// previous content to be available for viewing. A reset clears out all previous content
        /// from the origin endpoint.
        /// 
        ///  
        /// <para>
        /// MediaPackage might return old content from this endpoint in the first 30 seconds after
        /// the endpoint reset. For best results, when possible, wait 30 seconds from endpoint
        /// reset to send playback requests to this endpoint. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetOriginEndpointState service method.</param>
        /// 
        /// <returns>The response from the ResetOriginEndpointState service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ResetOriginEndpointState">REST API Reference for ResetOriginEndpointState Operation</seealso>
        ResetOriginEndpointStateResponse ResetOriginEndpointState(ResetOriginEndpointStateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetOriginEndpointState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetOriginEndpointState operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetOriginEndpointState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ResetOriginEndpointState">REST API Reference for ResetOriginEndpointState Operation</seealso>
        IAsyncResult BeginResetOriginEndpointState(ResetOriginEndpointStateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetOriginEndpointState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetOriginEndpointState.</param>
        /// 
        /// <returns>Returns a  ResetOriginEndpointStateResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ResetOriginEndpointState">REST API Reference for ResetOriginEndpointState Operation</seealso>
        ResetOriginEndpointStateResponse EndResetOriginEndpointState(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one of more tags (key-value pairs) to the specified MediaPackage resource.
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions, by granting a user permission to access or change only resources
        /// with certain tag values. You can use the TagResource operation with a resource that
        /// already has tags. If you specify a new tag key for the resource, this tag is appended
        /// to the list of tags associated with the resource. If you specify a tag key that is
        /// already associated with the resource, the new tag value that you specify replaces
        /// the previous value for that tag.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateChannel


        /// <summary>
        /// Update the specified channel. You can edit if MediaPackage sends ingest or egress
        /// access logs to the CloudWatch log group, if content will be encrypted, the description
        /// on a channel, and your channel's policy settings. You can't edit the name of the channel
        /// or CloudFront distribution details.
        /// 
        ///  
        /// <para>
        /// Any edits you make that impact the video output may not be reflected for a few minutes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        UpdateChannelResponse UpdateChannel(UpdateChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        IAsyncResult BeginUpdateChannel(UpdateChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannel.</param>
        /// 
        /// <returns>Returns a  UpdateChannelResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        UpdateChannelResponse EndUpdateChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateChannelGroup


        /// <summary>
        /// Update the specified channel group. You can edit the description on a channel group
        /// for easier identification later from the AWS Elemental MediaPackage console. You can't
        /// edit the name of the channel group.
        /// 
        ///  
        /// <para>
        /// Any edits you make that impact the video output may not be reflected for a few minutes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateChannelGroup service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/UpdateChannelGroup">REST API Reference for UpdateChannelGroup Operation</seealso>
        UpdateChannelGroupResponse UpdateChannelGroup(UpdateChannelGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannelGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelGroup operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannelGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/UpdateChannelGroup">REST API Reference for UpdateChannelGroup Operation</seealso>
        IAsyncResult BeginUpdateChannelGroup(UpdateChannelGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannelGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannelGroup.</param>
        /// 
        /// <returns>Returns a  UpdateChannelGroupResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/UpdateChannelGroup">REST API Reference for UpdateChannelGroup Operation</seealso>
        UpdateChannelGroupResponse EndUpdateChannelGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateOriginEndpoint


        /// <summary>
        /// Update the specified origin endpoint. Edit the packaging preferences on an endpoint
        /// to optimize the viewing experience. You can't edit the name of the endpoint.
        /// 
        ///  
        /// <para>
        /// Any edits you make that impact the video output may not be reflected for a few minutes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOriginEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateOriginEndpoint service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/UpdateOriginEndpoint">REST API Reference for UpdateOriginEndpoint Operation</seealso>
        UpdateOriginEndpointResponse UpdateOriginEndpoint(UpdateOriginEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOriginEndpoint operation on AmazonMediaPackageV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOriginEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/UpdateOriginEndpoint">REST API Reference for UpdateOriginEndpoint Operation</seealso>
        IAsyncResult BeginUpdateOriginEndpoint(UpdateOriginEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOriginEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateOriginEndpointResult from MediaPackageV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/UpdateOriginEndpoint">REST API Reference for UpdateOriginEndpoint Operation</seealso>
        UpdateOriginEndpointResponse EndUpdateOriginEndpoint(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}