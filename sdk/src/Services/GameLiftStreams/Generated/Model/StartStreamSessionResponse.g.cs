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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.GameLiftStreams.Model
{
    /// <summary>
    /// This is the response object from the StartStreamSession operation.
    /// </summary>
    public partial class StartStreamSessionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AdditionalEnvironmentVariables. 
        /// <para>
        /// A set of options that you can use to control the stream session runtime environment,
        /// expressed as a set of key-value pairs. You can use this to configure the application
        /// or stream session details. You can also provide custom environment variables that
        /// Amazon GameLift Streams passes to your game client.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you want to debug your application with environment variables, we recommend that
        /// you do so in a local environment outside of Amazon GameLift Streams. For more information,
        /// refer to the Compatibility Guidance in the troubleshooting section of the Developer
        /// Guide.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <c>AdditionalEnvironmentVariables</c> and <c>AdditionalLaunchArgs</c> have similar
        /// purposes. <c>AdditionalEnvironmentVariables</c> passes data using environment variables;
        /// while <c>AdditionalLaunchArgs</c> passes data using command-line arguments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> AdditionalEnvironmentVariables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalEnvironmentVariables property is set.
        /// </summary>
        internal bool IsSetAdditionalEnvironmentVariables() => this.AdditionalEnvironmentVariables != null && (this.AdditionalEnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AdditionalLaunchArgs. 
        /// <para>
        /// A list of CLI arguments that are sent to the streaming server when a stream session
        /// launches. You can use this to configure the application or stream session details.
        /// You can also provide custom arguments that Amazon GameLift Streams passes to your
        /// game client.
        /// </para>
        ///  
        /// <para>
        ///  <c>AdditionalEnvironmentVariables</c> and <c>AdditionalLaunchArgs</c> have similar
        /// purposes. <c>AdditionalEnvironmentVariables</c> passes data using environment variables;
        /// while <c>AdditionalLaunchArgs</c> passes data using command-line arguments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> AdditionalLaunchArgs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalLaunchArgs property is set.
        /// </summary>
        internal bool IsSetAdditionalLaunchArgs() => this.AdditionalLaunchArgs != null && (this.AdditionalLaunchArgs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The application streaming in this session.
        /// </para>
        ///  
        /// <para>
        /// This value is an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> that uniquely identifies the application resource. Example
        /// ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:application/a-9ZY8X7Wv6</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationArn property is set.
        /// </summary>
        internal bool IsSetApplicationArn() => this.ApplicationArn != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> that's assigned to a stream session resource. When combined
        /// with the stream group resource ID, this value uniquely identifies the stream session
        /// across all Amazon Web Services Regions. Format is <c>arn:aws:gameliftstreams:[AWS
        /// Region]:[AWS account]:streamsession/[stream group resource ID]/[stream session resource
        /// ID]</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ConnectionTimeoutSeconds. 
        /// <para>
        /// The length of time that Amazon GameLift Streams should wait for a client to connect
        /// or reconnect to the stream session. This time span starts when the stream session
        /// reaches <c>ACTIVE</c> or <c>PENDING_CLIENT_RECONNECTION</c> state. If no client connects
        /// (or reconnects) before the timeout, Amazon GameLift Streams terminates the stream
        /// session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 3600)]
        public int? ConnectionTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetConnectionTimeoutSeconds() => this.ConnectionTimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// A timestamp that indicates when this resource was created. Timestamps are expressed
        /// using in ISO8601 format, such as: <c>2022-12-27T22:29:40+00:00</c> (UTC).
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable label for the stream session. You can update this value at any time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 80)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayConfiguration. 
        /// <para>
        /// The configuration for the stream session's virtual monitor.
        /// </para>
        /// </summary>
        public DisplayConfiguration DisplayConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DisplayConfiguration property is set.
        /// </summary>
        internal bool IsSetDisplayConfiguration() => this.DisplayConfiguration != null;

        /// <summary>
        /// Gets and sets the property ExportFilesMetadata. 
        /// <para>
        /// Provides details about the stream session's exported files. 
        /// </para>
        /// </summary>
        public ExportFilesMetadata ExportFilesMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ExportFilesMetadata property is set.
        /// </summary>
        internal bool IsSetExportFilesMetadata() => this.ExportFilesMetadata != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// A timestamp that indicates when this resource was last updated. Timestamps are expressed
        /// using in ISO8601 format, such as: <c>2022-12-27T22:29:40+00:00</c> (UTC).
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location where Amazon GameLift Streams hosts and streams your application. For
        /// example, <c>us-east-1</c>. For a complete list of locations that Amazon GameLift Streams
        /// supports, refer to <a href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/regions-quotas.html">Regions,
        /// quotas, and limitations</a> in the <i>Amazon GameLift Streams Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property LogFileLocationUri. 
        /// <para>
        /// Access location for log files that your content generates during a stream session.
        /// These log files are uploaded to cloud storage location at the end of a stream session.
        /// The Amazon GameLift Streams application resource defines which log files to upload.
        /// </para>
        /// </summary>
        public string LogFileLocationUri { get; set; }

        /// <summary>
        /// Checks to see if the LogFileLocationUri property is set.
        /// </summary>
        internal bool IsSetLogFileLocationUri() => this.LogFileLocationUri != null;

        /// <summary>
        /// Gets and sets the property PerformanceStatsConfiguration. 
        /// <para>
        /// The performance stats configuration for the stream session
        /// </para>
        /// </summary>
        public PerformanceStatsConfiguration PerformanceStatsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceStatsConfiguration property is set.
        /// </summary>
        internal bool IsSetPerformanceStatsConfiguration() => this.PerformanceStatsConfiguration != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The data transfer protocol in use with the stream session.
        /// </para>
        /// </summary>
        public Protocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the AWS Identity and Access Management (IAM) role that Amazon GameLift
        /// Streams assumes on behalf of your application during the stream session.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SessionLengthSeconds. 
        /// <para>
        /// The maximum duration of a session. Amazon GameLift Streams will automatically terminate
        /// a session after this amount of time has elapsed, regardless of any existing client
        /// connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 86400)]
        public int? SessionLengthSeconds { get; set; }

        /// <summary>
        /// Checks to see if the SessionLengthSeconds property is set.
        /// </summary>
        internal bool IsSetSessionLengthSeconds() => this.SessionLengthSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property SignalRequest. 
        /// <para>
        /// The WebRTC ICE offer string that a client generates to initiate a connection to the
        /// stream session.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1)]
        public string SignalRequest { get; set; }

        /// <summary>
        /// Checks to see if the SignalRequest property is set.
        /// </summary>
        internal bool IsSetSignalRequest() => this.SignalRequest != null;

        /// <summary>
        /// Gets and sets the property SignalResponse. 
        /// <para>
        /// The WebRTC answer string that the stream server generates in response to the <c>SignalRequest</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string SignalResponse { get; set; }

        /// <summary>
        /// Checks to see if the SignalResponse property is set.
        /// </summary>
        internal bool IsSetSignalResponse() => this.SignalResponse != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the stream session. A stream session is ready for a client to
        /// connect when in <c>ACTIVE</c> status.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVATING</c>: The stream session is starting and preparing to stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c>: The stream session is ready and waiting for a client connection. A
        /// client has <c>ConnectionTimeoutSeconds</c> (specified in <c>StartStreamSession</c>)
        /// from when the session reaches <c>ACTIVE</c> state to establish a connection. If no
        /// client connects within this timeframe, the session automatically terminates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONNECTED</c>: The stream session has a connected client. A session will automatically
        /// terminate if there is no user input for 60 minutes, or if the maximum length of a
        /// session specified by <c>SessionLengthSeconds</c> in <c>StartStreamSession</c> is exceeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c>: The stream session failed to activate. See <c>StatusReason</c> (returned
        /// by <c>GetStreamSession</c> and <c>StartStreamSession</c>) for more information.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_CLIENT_RECONNECTION</c>: A client has recently disconnected and the stream
        /// session is waiting for the client to reconnect. A client has <c>ConnectionTimeoutSeconds</c>
        /// (specified in <c>StartStreamSession</c>) from when the session reaches <c>PENDING_CLIENT_RECONNECTION</c>
        /// state to re-establish a connection. If no client connects within this timeframe, the
        /// session automatically terminates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RECONNECTING</c>: A client has initiated a reconnect to a session that was in
        /// <c>PENDING_CLIENT_RECONNECTION</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TERMINATING</c>: The stream session is ending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TERMINATED</c>: The stream session has ended.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StreamSessionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short description of the reason the stream session is in <c>ERROR</c> status or
        /// <c>TERMINATED</c> status.
        /// </para>
        ///  
        /// <para>
        ///  <c>ERROR</c> status reasons:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>applicationLogS3DestinationError</c>: Could not write the application log to the
        /// Amazon S3 bucket that is configured for the streaming application. Make sure the bucket
        /// still exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>internalError</c>: An internal service error occurred. Start a new stream session
        /// to continue streaming.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>invalidSignalRequest</c>: The WebRTC signal request that was sent is not valid.
        /// When starting or reconnecting to a stream session, use <c>generateSignalRequest</c>
        /// in the Amazon GameLift Streams Web SDK to generate a new signal request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>placementTimeout</c>: Amazon GameLift Streams could not find available stream
        /// capacity to start a stream session. Increase the stream capacity in the stream group
        /// or wait until capacity becomes available.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>TERMINATED</c> status reasons:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>apiTerminated</c>: The stream session was terminated by an API call to <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_TerminateStreamSession.html">TerminateStreamSession</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>applicationExit</c>: The streaming application exited or crashed. The stream session
        /// was terminated because the application is no longer running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>connectionTimeout</c>: The stream session was terminated because the client failed
        /// to connect within the connection timeout period specified by <c>ConnectionTimeoutSeconds</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>maxSessionLengthTimeout</c>: The stream session was terminated because it exceeded
        /// the maximum session length timeout period specified by <c>SessionLengthSeconds</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>reconnectionTimeout</c>: The stream session was terminated because the client
        /// failed to reconnect within the reconnection timeout period specified by <c>ConnectionTimeoutSeconds</c>
        /// after losing connection.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StreamSessionStatusReason StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property StreamGroupId. 
        /// <para>
        /// The unique identifier for the Amazon GameLift Streams stream group that is hosting
        /// the stream session. Format example: <c>sg-1AB2C3De4</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string StreamGroupId { get; set; }

        /// <summary>
        /// Checks to see if the StreamGroupId property is set.
        /// </summary>
        internal bool IsSetStreamGroupId() => this.StreamGroupId != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        ///  An opaque, unique identifier for an end-user, defined by the developer. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;

        /// <summary>
        /// Gets and sets the property WebSdkProtocolUrl. 
        /// <para>
        /// The URL of an S3 bucket that stores Amazon GameLift Streams WebSDK files. The URL
        /// is used to establish connection with the client.
        /// </para>
        /// </summary>
        public string WebSdkProtocolUrl { get; set; }

        /// <summary>
        /// Checks to see if the WebSdkProtocolUrl property is set.
        /// </summary>
        internal bool IsSetWebSdkProtocolUrl() => this.WebSdkProtocolUrl != null;
    }
}
