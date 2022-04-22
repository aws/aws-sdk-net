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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ChimeSDKMeetings.Model;

namespace Amazon.ChimeSDKMeetings
{
    /// <summary>
    /// Interface for accessing ChimeSDKMeetings
    ///
    /// The Amazon Chime SDK meetings APIs in this section allow software developers to create
    /// Amazon Chime SDK meetings, set the AWS Regions for meetings, create and manage users,
    /// and send and receive meeting notifications. For more information about the meeting
    /// APIs, see <a href="https://docs.aws.amazon.com/chime/latest/APIReference/API_Operations_Amazon_Chime_SDK_Meetings.html">Amazon
    /// Chime SDK meetings</a>.
    /// </summary>
    public partial interface IAmazonChimeSDKMeetings : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IChimeSDKMeetingsPaginatorFactory Paginators { get; }
#endif


        
        #region  BatchCreateAttendee


        /// <summary>
        /// Creates up to 100 attendees for an active Amazon Chime SDK meeting. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateAttendee service method.</param>
        /// 
        /// <returns>The response from the BatchCreateAttendee service method, as returned by ChimeSDKMeetings.</returns>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.LimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ThrottlingException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnauthorizedException">
        /// The user isn't authorized to request a resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnprocessableEntityException">
        /// The request was well-formed but was unable to be followed due to semantic errors.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/BatchCreateAttendee">REST API Reference for BatchCreateAttendee Operation</seealso>
        BatchCreateAttendeeResponse BatchCreateAttendee(BatchCreateAttendeeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateAttendee operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateAttendee operation on AmazonChimeSDKMeetingsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateAttendee
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/BatchCreateAttendee">REST API Reference for BatchCreateAttendee Operation</seealso>
        IAsyncResult BeginBatchCreateAttendee(BatchCreateAttendeeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateAttendee operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateAttendee.</param>
        /// 
        /// <returns>Returns a  BatchCreateAttendeeResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/BatchCreateAttendee">REST API Reference for BatchCreateAttendee Operation</seealso>
        BatchCreateAttendeeResponse EndBatchCreateAttendee(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAttendee


        /// <summary>
        /// Creates a new attendee for an active Amazon Chime SDK meeting. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAttendee service method.</param>
        /// 
        /// <returns>The response from the CreateAttendee service method, as returned by ChimeSDKMeetings.</returns>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.LimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ThrottlingException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnauthorizedException">
        /// The user isn't authorized to request a resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnprocessableEntityException">
        /// The request was well-formed but was unable to be followed due to semantic errors.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/CreateAttendee">REST API Reference for CreateAttendee Operation</seealso>
        CreateAttendeeResponse CreateAttendee(CreateAttendeeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAttendee operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAttendee operation on AmazonChimeSDKMeetingsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAttendee
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/CreateAttendee">REST API Reference for CreateAttendee Operation</seealso>
        IAsyncResult BeginCreateAttendee(CreateAttendeeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAttendee operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAttendee.</param>
        /// 
        /// <returns>Returns a  CreateAttendeeResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/CreateAttendee">REST API Reference for CreateAttendee Operation</seealso>
        CreateAttendeeResponse EndCreateAttendee(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMeeting


        /// <summary>
        /// Creates a new Amazon Chime SDK meeting in the specified media Region with no initial
        /// attendees. For more information about specifying media Regions, see <a href="https://docs.aws.amazon.com/chime/latest/dg/chime-sdk-meetings-regions.html">Amazon
        /// Chime SDK Media Regions</a> in the <i>Amazon Chime Developer Guide</i>. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMeeting service method.</param>
        /// 
        /// <returns>The response from the CreateMeeting service method, as returned by ChimeSDKMeetings.</returns>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.LimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ThrottlingException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnauthorizedException">
        /// The user isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/CreateMeeting">REST API Reference for CreateMeeting Operation</seealso>
        CreateMeetingResponse CreateMeeting(CreateMeetingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMeeting operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMeeting operation on AmazonChimeSDKMeetingsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMeeting
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/CreateMeeting">REST API Reference for CreateMeeting Operation</seealso>
        IAsyncResult BeginCreateMeeting(CreateMeetingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMeeting operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMeeting.</param>
        /// 
        /// <returns>Returns a  CreateMeetingResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/CreateMeeting">REST API Reference for CreateMeeting Operation</seealso>
        CreateMeetingResponse EndCreateMeeting(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMeetingWithAttendees


        /// <summary>
        /// Creates a new Amazon Chime SDK meeting in the specified media Region, with attendees.
        /// For more information about specifying media Regions, see <a href="https://docs.aws.amazon.com/chime/latest/dg/chime-sdk-meetings-regions.html">Amazon
        /// Chime SDK Media Regions</a> in the <i>Amazon Chime Developer Guide</i>. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMeetingWithAttendees service method.</param>
        /// 
        /// <returns>The response from the CreateMeetingWithAttendees service method, as returned by ChimeSDKMeetings.</returns>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.LimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ThrottlingException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnauthorizedException">
        /// The user isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/CreateMeetingWithAttendees">REST API Reference for CreateMeetingWithAttendees Operation</seealso>
        CreateMeetingWithAttendeesResponse CreateMeetingWithAttendees(CreateMeetingWithAttendeesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMeetingWithAttendees operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMeetingWithAttendees operation on AmazonChimeSDKMeetingsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMeetingWithAttendees
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/CreateMeetingWithAttendees">REST API Reference for CreateMeetingWithAttendees Operation</seealso>
        IAsyncResult BeginCreateMeetingWithAttendees(CreateMeetingWithAttendeesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMeetingWithAttendees operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMeetingWithAttendees.</param>
        /// 
        /// <returns>Returns a  CreateMeetingWithAttendeesResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/CreateMeetingWithAttendees">REST API Reference for CreateMeetingWithAttendees Operation</seealso>
        CreateMeetingWithAttendeesResponse EndCreateMeetingWithAttendees(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAttendee


        /// <summary>
        /// Deletes an attendee from the specified Amazon Chime SDK meeting and deletes their
        /// <code>JoinToken</code>. Attendees are automatically deleted when a Amazon Chime SDK
        /// meeting is deleted. For more information about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttendee service method.</param>
        /// 
        /// <returns>The response from the DeleteAttendee service method, as returned by ChimeSDKMeetings.</returns>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ThrottlingException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnauthorizedException">
        /// The user isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/DeleteAttendee">REST API Reference for DeleteAttendee Operation</seealso>
        DeleteAttendeeResponse DeleteAttendee(DeleteAttendeeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAttendee operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttendee operation on AmazonChimeSDKMeetingsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAttendee
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/DeleteAttendee">REST API Reference for DeleteAttendee Operation</seealso>
        IAsyncResult BeginDeleteAttendee(DeleteAttendeeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAttendee operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAttendee.</param>
        /// 
        /// <returns>Returns a  DeleteAttendeeResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/DeleteAttendee">REST API Reference for DeleteAttendee Operation</seealso>
        DeleteAttendeeResponse EndDeleteAttendee(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMeeting


        /// <summary>
        /// Deletes the specified Amazon Chime SDK meeting. The operation deletes all attendees,
        /// disconnects all clients, and prevents new clients from joining the meeting. For more
        /// information about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMeeting service method.</param>
        /// 
        /// <returns>The response from the DeleteMeeting service method, as returned by ChimeSDKMeetings.</returns>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ThrottlingException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnauthorizedException">
        /// The user isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/DeleteMeeting">REST API Reference for DeleteMeeting Operation</seealso>
        DeleteMeetingResponse DeleteMeeting(DeleteMeetingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMeeting operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMeeting operation on AmazonChimeSDKMeetingsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMeeting
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/DeleteMeeting">REST API Reference for DeleteMeeting Operation</seealso>
        IAsyncResult BeginDeleteMeeting(DeleteMeetingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMeeting operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMeeting.</param>
        /// 
        /// <returns>Returns a  DeleteMeetingResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/DeleteMeeting">REST API Reference for DeleteMeeting Operation</seealso>
        DeleteMeetingResponse EndDeleteMeeting(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAttendee


        /// <summary>
        /// Gets the Amazon Chime SDK attendee details for a specified meeting ID and attendee
        /// ID. For more information about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAttendee service method.</param>
        /// 
        /// <returns>The response from the GetAttendee service method, as returned by ChimeSDKMeetings.</returns>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ThrottlingException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnauthorizedException">
        /// The user isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/GetAttendee">REST API Reference for GetAttendee Operation</seealso>
        GetAttendeeResponse GetAttendee(GetAttendeeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAttendee operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAttendee operation on AmazonChimeSDKMeetingsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAttendee
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/GetAttendee">REST API Reference for GetAttendee Operation</seealso>
        IAsyncResult BeginGetAttendee(GetAttendeeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAttendee operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAttendee.</param>
        /// 
        /// <returns>Returns a  GetAttendeeResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/GetAttendee">REST API Reference for GetAttendee Operation</seealso>
        GetAttendeeResponse EndGetAttendee(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMeeting


        /// <summary>
        /// Gets the Amazon Chime SDK meeting details for the specified meeting ID. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMeeting service method.</param>
        /// 
        /// <returns>The response from the GetMeeting service method, as returned by ChimeSDKMeetings.</returns>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ThrottlingException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnauthorizedException">
        /// The user isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/GetMeeting">REST API Reference for GetMeeting Operation</seealso>
        GetMeetingResponse GetMeeting(GetMeetingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMeeting operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMeeting operation on AmazonChimeSDKMeetingsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMeeting
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/GetMeeting">REST API Reference for GetMeeting Operation</seealso>
        IAsyncResult BeginGetMeeting(GetMeetingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMeeting operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMeeting.</param>
        /// 
        /// <returns>Returns a  GetMeetingResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/GetMeeting">REST API Reference for GetMeeting Operation</seealso>
        GetMeetingResponse EndGetMeeting(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAttendees


        /// <summary>
        /// Lists the attendees for the specified Amazon Chime SDK meeting. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttendees service method.</param>
        /// 
        /// <returns>The response from the ListAttendees service method, as returned by ChimeSDKMeetings.</returns>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ThrottlingException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnauthorizedException">
        /// The user isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/ListAttendees">REST API Reference for ListAttendees Operation</seealso>
        ListAttendeesResponse ListAttendees(ListAttendeesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttendees operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttendees operation on AmazonChimeSDKMeetingsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttendees
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/ListAttendees">REST API Reference for ListAttendees Operation</seealso>
        IAsyncResult BeginListAttendees(ListAttendeesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttendees operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttendees.</param>
        /// 
        /// <returns>Returns a  ListAttendeesResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/ListAttendees">REST API Reference for ListAttendees Operation</seealso>
        ListAttendeesResponse EndListAttendees(IAsyncResult asyncResult);

        #endregion
        
        #region  StartMeetingTranscription


        /// <summary>
        /// Starts transcription for the specified <code>meetingId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMeetingTranscription service method.</param>
        /// 
        /// <returns>The response from the StartMeetingTranscription service method, as returned by ChimeSDKMeetings.</returns>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.LimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ThrottlingException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnauthorizedException">
        /// The user isn't authorized to request a resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnprocessableEntityException">
        /// The request was well-formed but was unable to be followed due to semantic errors.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/StartMeetingTranscription">REST API Reference for StartMeetingTranscription Operation</seealso>
        StartMeetingTranscriptionResponse StartMeetingTranscription(StartMeetingTranscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartMeetingTranscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMeetingTranscription operation on AmazonChimeSDKMeetingsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMeetingTranscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/StartMeetingTranscription">REST API Reference for StartMeetingTranscription Operation</seealso>
        IAsyncResult BeginStartMeetingTranscription(StartMeetingTranscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartMeetingTranscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMeetingTranscription.</param>
        /// 
        /// <returns>Returns a  StartMeetingTranscriptionResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/StartMeetingTranscription">REST API Reference for StartMeetingTranscription Operation</seealso>
        StartMeetingTranscriptionResponse EndStartMeetingTranscription(IAsyncResult asyncResult);

        #endregion
        
        #region  StopMeetingTranscription


        /// <summary>
        /// Stops transcription for the specified <code>meetingId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopMeetingTranscription service method.</param>
        /// 
        /// <returns>The response from the StopMeetingTranscription service method, as returned by ChimeSDKMeetings.</returns>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ThrottlingException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnauthorizedException">
        /// The user isn't authorized to request a resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnprocessableEntityException">
        /// The request was well-formed but was unable to be followed due to semantic errors.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/StopMeetingTranscription">REST API Reference for StopMeetingTranscription Operation</seealso>
        StopMeetingTranscriptionResponse StopMeetingTranscription(StopMeetingTranscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopMeetingTranscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopMeetingTranscription operation on AmazonChimeSDKMeetingsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopMeetingTranscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/StopMeetingTranscription">REST API Reference for StopMeetingTranscription Operation</seealso>
        IAsyncResult BeginStopMeetingTranscription(StopMeetingTranscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopMeetingTranscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopMeetingTranscription.</param>
        /// 
        /// <returns>Returns a  StopMeetingTranscriptionResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/StopMeetingTranscription">REST API Reference for StopMeetingTranscription Operation</seealso>
        StopMeetingTranscriptionResponse EndStopMeetingTranscription(IAsyncResult asyncResult);

        #endregion
        
    }
}