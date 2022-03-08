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
using System.Net;

using Amazon.ChimeSDKMeetings.Model;
using Amazon.ChimeSDKMeetings.Model.Internal.MarshallTransformations;
using Amazon.ChimeSDKMeetings.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ChimeSDKMeetings
{
    /// <summary>
    /// Implementation for accessing ChimeSDKMeetings
    ///
    /// The Amazon Chime SDK meetings APIs in this section allow software developers to create
    /// Amazon Chime SDK meetings, set the AWS Regions for meetings, create and manage users,
    /// and send and receive meeting notifications. For more information about the meeting
    /// APIs, see <a href="https://docs.aws.amazon.com/chime/latest/APIReference/API_Operations_Amazon_Chime_SDK_Meetings.html">Amazon
    /// Chime SDK meetings</a>.
    /// </summary>
    public partial class AmazonChimeSDKMeetingsClient : AmazonServiceClient, IAmazonChimeSDKMeetings
    {
        private static IServiceMetadata serviceMetadata = new AmazonChimeSDKMeetingsMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IChimeSDKMeetingsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IChimeSDKMeetingsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ChimeSDKMeetingsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonChimeSDKMeetingsClient with the credentials loaded from the application's
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
        public AmazonChimeSDKMeetingsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonChimeSDKMeetingsConfig()) { }

        /// <summary>
        /// Constructs AmazonChimeSDKMeetingsClient with the credentials loaded from the application's
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
        public AmazonChimeSDKMeetingsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonChimeSDKMeetingsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonChimeSDKMeetingsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonChimeSDKMeetingsClient Configuration Object</param>
        public AmazonChimeSDKMeetingsClient(AmazonChimeSDKMeetingsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonChimeSDKMeetingsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonChimeSDKMeetingsClient(AWSCredentials credentials)
            : this(credentials, new AmazonChimeSDKMeetingsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMeetingsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKMeetingsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonChimeSDKMeetingsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMeetingsClient with AWS Credentials and an
        /// AmazonChimeSDKMeetingsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonChimeSDKMeetingsClient Configuration Object</param>
        public AmazonChimeSDKMeetingsClient(AWSCredentials credentials, AmazonChimeSDKMeetingsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMeetingsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonChimeSDKMeetingsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonChimeSDKMeetingsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMeetingsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKMeetingsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonChimeSDKMeetingsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMeetingsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonChimeSDKMeetingsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonChimeSDKMeetingsClient Configuration Object</param>
        public AmazonChimeSDKMeetingsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonChimeSDKMeetingsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMeetingsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonChimeSDKMeetingsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonChimeSDKMeetingsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMeetingsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKMeetingsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonChimeSDKMeetingsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMeetingsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonChimeSDKMeetingsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonChimeSDKMeetingsClient Configuration Object</param>
        public AmazonChimeSDKMeetingsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonChimeSDKMeetingsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

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
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnauthorizedException">
        /// The user isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/BatchCreateAttendee">REST API Reference for BatchCreateAttendee Operation</seealso>
        public virtual BatchCreateAttendeeResponse BatchCreateAttendee(BatchCreateAttendeeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateAttendeeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateAttendeeResponseUnmarshaller.Instance;

            return Invoke<BatchCreateAttendeeResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginBatchCreateAttendee(BatchCreateAttendeeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateAttendeeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateAttendeeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateAttendee operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateAttendee.</param>
        /// 
        /// <returns>Returns a  BatchCreateAttendeeResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/BatchCreateAttendee">REST API Reference for BatchCreateAttendee Operation</seealso>
        public virtual BatchCreateAttendeeResponse EndBatchCreateAttendee(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchCreateAttendeeResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnauthorizedException">
        /// The user isn't authorized to request a resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnprocessableEntityException">
        /// The request was well-formed but was unable to be followed due to semantic errors.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/CreateAttendee">REST API Reference for CreateAttendee Operation</seealso>
        public virtual CreateAttendeeResponse CreateAttendee(CreateAttendeeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAttendeeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAttendeeResponseUnmarshaller.Instance;

            return Invoke<CreateAttendeeResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginCreateAttendee(CreateAttendeeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAttendeeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAttendeeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAttendee operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAttendee.</param>
        /// 
        /// <returns>Returns a  CreateAttendeeResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/CreateAttendee">REST API Reference for CreateAttendee Operation</seealso>
        public virtual CreateAttendeeResponse EndCreateAttendee(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAttendeeResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.LimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnauthorizedException">
        /// The user isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/CreateMeeting">REST API Reference for CreateMeeting Operation</seealso>
        public virtual CreateMeetingResponse CreateMeeting(CreateMeetingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMeetingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMeetingResponseUnmarshaller.Instance;

            return Invoke<CreateMeetingResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginCreateMeeting(CreateMeetingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMeetingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMeetingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMeeting operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMeeting.</param>
        /// 
        /// <returns>Returns a  CreateMeetingResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/CreateMeeting">REST API Reference for CreateMeeting Operation</seealso>
        public virtual CreateMeetingResponse EndCreateMeeting(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMeetingResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.LimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnauthorizedException">
        /// The user isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/CreateMeetingWithAttendees">REST API Reference for CreateMeetingWithAttendees Operation</seealso>
        public virtual CreateMeetingWithAttendeesResponse CreateMeetingWithAttendees(CreateMeetingWithAttendeesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMeetingWithAttendeesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMeetingWithAttendeesResponseUnmarshaller.Instance;

            return Invoke<CreateMeetingWithAttendeesResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginCreateMeetingWithAttendees(CreateMeetingWithAttendeesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMeetingWithAttendeesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMeetingWithAttendeesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMeetingWithAttendees operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMeetingWithAttendees.</param>
        /// 
        /// <returns>Returns a  CreateMeetingWithAttendeesResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/CreateMeetingWithAttendees">REST API Reference for CreateMeetingWithAttendees Operation</seealso>
        public virtual CreateMeetingWithAttendeesResponse EndCreateMeetingWithAttendees(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMeetingWithAttendeesResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/DeleteAttendee">REST API Reference for DeleteAttendee Operation</seealso>
        public virtual DeleteAttendeeResponse DeleteAttendee(DeleteAttendeeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAttendeeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAttendeeResponseUnmarshaller.Instance;

            return Invoke<DeleteAttendeeResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDeleteAttendee(DeleteAttendeeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAttendeeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAttendeeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAttendee operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAttendee.</param>
        /// 
        /// <returns>Returns a  DeleteAttendeeResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/DeleteAttendee">REST API Reference for DeleteAttendee Operation</seealso>
        public virtual DeleteAttendeeResponse EndDeleteAttendee(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAttendeeResponse>(asyncResult);
        }

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/DeleteMeeting">REST API Reference for DeleteMeeting Operation</seealso>
        public virtual DeleteMeetingResponse DeleteMeeting(DeleteMeetingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMeetingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMeetingResponseUnmarshaller.Instance;

            return Invoke<DeleteMeetingResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDeleteMeeting(DeleteMeetingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMeetingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMeetingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMeeting operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMeeting.</param>
        /// 
        /// <returns>Returns a  DeleteMeetingResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/DeleteMeeting">REST API Reference for DeleteMeeting Operation</seealso>
        public virtual DeleteMeetingResponse EndDeleteMeeting(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMeetingResponse>(asyncResult);
        }

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/GetAttendee">REST API Reference for GetAttendee Operation</seealso>
        public virtual GetAttendeeResponse GetAttendee(GetAttendeeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAttendeeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAttendeeResponseUnmarshaller.Instance;

            return Invoke<GetAttendeeResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginGetAttendee(GetAttendeeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAttendeeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAttendeeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAttendee operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAttendee.</param>
        /// 
        /// <returns>Returns a  GetAttendeeResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/GetAttendee">REST API Reference for GetAttendee Operation</seealso>
        public virtual GetAttendeeResponse EndGetAttendee(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAttendeeResponse>(asyncResult);
        }

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/GetMeeting">REST API Reference for GetMeeting Operation</seealso>
        public virtual GetMeetingResponse GetMeeting(GetMeetingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMeetingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMeetingResponseUnmarshaller.Instance;

            return Invoke<GetMeetingResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginGetMeeting(GetMeetingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMeetingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMeetingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMeeting operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMeeting.</param>
        /// 
        /// <returns>Returns a  GetMeetingResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/GetMeeting">REST API Reference for GetMeeting Operation</seealso>
        public virtual GetMeetingResponse EndGetMeeting(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMeetingResponse>(asyncResult);
        }

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/ListAttendees">REST API Reference for ListAttendees Operation</seealso>
        public virtual ListAttendeesResponse ListAttendees(ListAttendeesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttendeesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttendeesResponseUnmarshaller.Instance;

            return Invoke<ListAttendeesResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListAttendees(ListAttendeesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttendeesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttendeesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttendees operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttendees.</param>
        /// 
        /// <returns>Returns a  ListAttendeesResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/ListAttendees">REST API Reference for ListAttendees Operation</seealso>
        public virtual ListAttendeesResponse EndListAttendees(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAttendeesResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnauthorizedException">
        /// The user isn't authorized to request a resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnprocessableEntityException">
        /// The request was well-formed but was unable to be followed due to semantic errors.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/StartMeetingTranscription">REST API Reference for StartMeetingTranscription Operation</seealso>
        public virtual StartMeetingTranscriptionResponse StartMeetingTranscription(StartMeetingTranscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMeetingTranscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMeetingTranscriptionResponseUnmarshaller.Instance;

            return Invoke<StartMeetingTranscriptionResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginStartMeetingTranscription(StartMeetingTranscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMeetingTranscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMeetingTranscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartMeetingTranscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMeetingTranscription.</param>
        /// 
        /// <returns>Returns a  StartMeetingTranscriptionResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/StartMeetingTranscription">REST API Reference for StartMeetingTranscription Operation</seealso>
        public virtual StartMeetingTranscriptionResponse EndStartMeetingTranscription(IAsyncResult asyncResult)
        {
            return EndInvoke<StartMeetingTranscriptionResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnauthorizedException">
        /// The user isn't authorized to request a resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMeetings.Model.UnprocessableEntityException">
        /// The request was well-formed but was unable to be followed due to semantic errors.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/StopMeetingTranscription">REST API Reference for StopMeetingTranscription Operation</seealso>
        public virtual StopMeetingTranscriptionResponse StopMeetingTranscription(StopMeetingTranscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopMeetingTranscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopMeetingTranscriptionResponseUnmarshaller.Instance;

            return Invoke<StopMeetingTranscriptionResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginStopMeetingTranscription(StopMeetingTranscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopMeetingTranscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopMeetingTranscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopMeetingTranscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopMeetingTranscription.</param>
        /// 
        /// <returns>Returns a  StopMeetingTranscriptionResult from ChimeSDKMeetings.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-meetings-2021-07-15/StopMeetingTranscription">REST API Reference for StopMeetingTranscription Operation</seealso>
        public virtual StopMeetingTranscriptionResponse EndStopMeetingTranscription(IAsyncResult asyncResult)
        {
            return EndInvoke<StopMeetingTranscriptionResponse>(asyncResult);
        }

        #endregion
        
    }
}