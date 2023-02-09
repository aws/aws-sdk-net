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
using System.Threading;
using System.Threading.Tasks;
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
#if AWS_ASYNC_ENUMERABLES_API
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchCreateAttendeeResponse> BatchCreateAttendeeAsync(BatchCreateAttendeeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchUpdateAttendeeCapabilitiesExcept



        /// <summary>
        /// Updates <code>AttendeeCapabilities</code> except the capabilities listed in an <code>ExcludedAttendeeIds</code>
        /// table.
        /// 
        ///  <note> 
        /// <para>
        /// You use the capabilities with a set of values that control what the capabilities can
        /// do, such as <code>SendReceive</code> data. For more information about those values,
        /// see .
        /// </para>
        ///  </note> 
        /// <para>
        /// When using capabilities, be aware of these corner cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can't set <code>content</code> capabilities to <code>SendReceive</code> or <code>Receive</code>
        /// unless you also set <code>video</code> capabilities to <code>SendReceive</code> or
        /// <code>Receive</code>. If you don't set the <code>video</code> capability to receive,
        /// the response will contain an HTTP 400 Bad Request status code. However, you can set
        /// your <code>video</code> capability to receive and you set your <code>content</code>
        /// capability to not receive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you change an <code>audio</code> capability from <code>None</code> or <code>Receive</code>
        /// to <code>Send</code> or <code>SendReceive</code> , and if the attendee left their
        /// microphone unmuted, audio will flow from the attendee to the other meeting participants.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you change a <code>video</code> or <code>content</code> capability from <code>None</code>
        /// or <code>Receive</code> to <code>Send</code> or <code>SendReceive</code> , and if
        /// the attendee turned on their video or content streams, remote attendess can receive
        /// those streams, but only after media renegotiation between the client and the Amazon
        /// Chime back-end server.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateAttendeeCapabilitiesExcept service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateAttendeeCapabilitiesExcept service method, as returned by ChimeSDKMeetings.</returns>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ConflictException">
        /// Multiple instances of the same request have been made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnauthorizedException">
        /// The user isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/BatchUpdateAttendeeCapabilitiesExcept">REST API Reference for BatchUpdateAttendeeCapabilitiesExcept Operation</seealso>
        Task<BatchUpdateAttendeeCapabilitiesExceptResponse> BatchUpdateAttendeeCapabilitiesExceptAsync(BatchUpdateAttendeeCapabilitiesExceptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAttendee



        /// <summary>
        /// Creates a new attendee for an active Amazon Chime SDK meeting. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAttendee service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateAttendeeResponse> CreateAttendeeAsync(CreateAttendeeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateMeetingResponse> CreateMeetingAsync(CreateMeetingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateMeetingWithAttendeesResponse> CreateMeetingWithAttendeesAsync(CreateMeetingWithAttendeesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAttendee



        /// <summary>
        /// Deletes an attendee from the specified Amazon Chime SDK meeting and deletes their
        /// <code>JoinToken</code>. Attendees are automatically deleted when a Amazon Chime SDK
        /// meeting is deleted. For more information about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttendee service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAttendeeResponse> DeleteAttendeeAsync(DeleteAttendeeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMeeting



        /// <summary>
        /// Deletes the specified Amazon Chime SDK meeting. The operation deletes all attendees,
        /// disconnects all clients, and prevents new clients from joining the meeting. For more
        /// information about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMeeting service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteMeetingResponse> DeleteMeetingAsync(DeleteMeetingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAttendee



        /// <summary>
        /// Gets the Amazon Chime SDK attendee details for a specified meeting ID and attendee
        /// ID. For more information about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAttendee service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAttendeeResponse> GetAttendeeAsync(GetAttendeeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMeeting



        /// <summary>
        /// Gets the Amazon Chime SDK meeting details for the specified meeting ID. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMeeting service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetMeetingResponse> GetMeetingAsync(GetMeetingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAttendees



        /// <summary>
        /// Lists the attendees for the specified Amazon Chime SDK meeting. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttendees service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAttendeesResponse> ListAttendeesAsync(ListAttendeesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Returns a list of the tags available for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ChimeSDKMeetings.</returns>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ResourceNotFoundException">
        /// The resource that you want to tag couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartMeetingTranscription



        /// <summary>
        /// Starts transcription for the specified <code>meetingId</code>. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/meeting-transcription.html">
        /// Using Amazon Chime SDK live transcription </a> in the <i>Amazon Chime SDK Developer
        /// Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        /// Amazon Chime SDK live transcription is powered by Amazon Transcribe. Use of Amazon
        /// Transcribe is subject to the <a href="https://aws.amazon.com/service-terms/">AWS Service
        /// Terms</a>, including the terms specific to the AWS Machine Learning and Artificial
        /// Intelligence Services.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMeetingTranscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartMeetingTranscriptionResponse> StartMeetingTranscriptionAsync(StartMeetingTranscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopMeetingTranscription



        /// <summary>
        /// Stops transcription for the specified <code>meetingId</code>. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/meeting-transcription.html">
        /// Using Amazon Chime SDK live transcription </a> in the <i>Amazon Chime SDK Developer
        /// Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        /// Amazon Chime SDK live transcription is powered by Amazon Transcribe. Use of Amazon
        /// Transcribe is subject to the <a href="https://aws.amazon.com/service-terms/">AWS Service
        /// Terms</a>, including the terms specific to the AWS Machine Learning and Artificial
        /// Intelligence Services.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopMeetingTranscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StopMeetingTranscriptionResponse> StopMeetingTranscriptionAsync(StopMeetingTranscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// The resource that supports tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ChimeSDKMeetings.</returns>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ResourceNotFoundException">
        /// The resource that you want to tag couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.TooManyTagsException">
        /// Too many tags were added to the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes the specified tags from the specified resources. When you specify a tag key,
        /// the action removes both that key and its associated value. The operation succeeds
        /// even if you attempt to remove tags from a resource that were already removed. Note
        /// the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// To remove tags from a resource, you need the necessary permissions for the service
        /// that the resource belongs to as well as permissions for removing tags. For more information,
        /// see the documentation for the service whose resource you want to untag.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only tag resources that are located in the specified AWS Region for the calling
        /// AWS account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// In addition to the <code>tag:UntagResources</code> permission required by this operation,
        /// you must also have the remove tags permission defined by the service that created
        /// the resource. For example, to remove the tags from an Amazon EC2 instance using the
        /// <code>UntagResources</code> operation, you must have both of the following permissions:
        /// </para>
        ///  
        /// <para>
        ///  <code>tag:UntagResource</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>ChimeSDKMeetings:DeleteTags</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ChimeSDKMeetings.</returns>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ResourceNotFoundException">
        /// The resource that you want to tag couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAttendeeCapabilities



        /// <summary>
        /// The capabilties that you want to update.
        /// 
        ///  <note> 
        /// <para>
        /// You use the capabilities with a set of values that control what the capabilities can
        /// do, such as <code>SendReceive</code> data. For more information about those values,
        /// see .
        /// </para>
        ///  </note> 
        /// <para>
        /// When using capabilities, be aware of these corner cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can't set <code>content</code> capabilities to <code>SendReceive</code> or <code>Receive</code>
        /// unless you also set <code>video</code> capabilities to <code>SendReceive</code> or
        /// <code>Receive</code>. If you don't set the <code>video</code> capability to receive,
        /// the response will contain an HTTP 400 Bad Request status code. However, you can set
        /// your <code>video</code> capability to receive and you set your <code>content</code>
        /// capability to not receive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you change an <code>audio</code> capability from <code>None</code> or <code>Receive</code>
        /// to <code>Send</code> or <code>SendReceive</code> , and if the attendee left their
        /// microphone unmuted, audio will flow from the attendee to the other meeting participants.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you change a <code>video</code> or <code>content</code> capability from <code>None</code>
        /// or <code>Receive</code> to <code>Send</code> or <code>SendReceive</code> , and if
        /// the attendee turned on their video or content streams, remote attendess can receive
        /// those streams, but only after media renegotiation between the client and the Amazon
        /// Chime back-end server.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAttendeeCapabilities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAttendeeCapabilities service method, as returned by ChimeSDKMeetings.</returns>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ConflictException">
        /// Multiple instances of the same request have been made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnauthorizedException">
        /// The user isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/UpdateAttendeeCapabilities">REST API Reference for UpdateAttendeeCapabilities Operation</seealso>
        Task<UpdateAttendeeCapabilitiesResponse> UpdateAttendeeCapabilitiesAsync(UpdateAttendeeCapabilitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}