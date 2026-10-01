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
    /// This is the response object from the CreateStreamUrl operation.
    /// </summary>
    public partial class CreateStreamUrlResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AdditionalEnvironmentVariables. 
        /// <para>
        /// The environment variables made available to the application when a stream session
        /// starts.
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
        /// The command-line arguments passed to the application when a stream session starts.
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
        /// The application that runs in the stream sessions.
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
        /// Resource Name (ARN)</a> that uniquely identifies the stream URL across all Amazon
        /// Web Services Regions. Format is <c>arn:aws:gameliftstreams:[AWS Region]:[AWS account]:streamurl/[stream
        /// group resource ID]/[stream URL resource ID]</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

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
        /// The descriptive label for the stream URL.
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
        /// The display settings, such as resolution, for stream sessions started from this stream
        /// URL.
        /// </para>
        /// </summary>
        public DisplayConfiguration DisplayConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DisplayConfiguration property is set.
        /// </summary>
        internal bool IsSetDisplayConfiguration() => this.DisplayConfiguration != null;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The date and time when the stream URL expires and stops accepting new stream sessions.
        /// Timestamps are expressed using in ISO8601 format, such as: <c>2022-12-27T22:29:40+00:00</c>
        /// (UTC).
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property Locations. 
        /// <para>
        /// The list of locations, in order of preference, where Amazon GameLift Streams places
        /// the stream session. For a complete list of locations that Amazon GameLift Streams
        /// supports, refer to <a href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/regions-quotas.html">Regions,
        /// quotas, and limitations</a> in the <i>Amazon GameLift Streams Developer Guide</i>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> Locations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Locations property is set.
        /// </summary>
        internal bool IsSetLocations() => this.Locations != null && (this.Locations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The data transport protocol used for stream sessions started from this stream URL.
        /// </para>
        /// </summary>
        public Protocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property RemainingUses. 
        /// <para>
        /// The number of times the stream URL can still be used to start a stream session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? RemainingUses { get; set; }

        /// <summary>
        /// Checks to see if the RemainingUses property is set.
        /// </summary>
        internal bool IsSetRemainingUses() => this.RemainingUses.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that Amazon GameLift Streams assumes
        /// during stream sessions started from this stream URL. For more information, see <a
        /// href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/session-credentials.html">Provide
        /// AWS credentials to your streaming application</a> in the <i>Amazon GameLift Streams
        /// Developer Guide</i>.
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
        /// The maximum length of time, in seconds, that a stream session started from this stream
        /// URL can run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 86400)]
        public int? SessionLengthSeconds { get; set; }

        /// <summary>
        /// Checks to see if the SessionLengthSeconds property is set.
        /// </summary>
        internal bool IsSetSessionLengthSeconds() => this.SessionLengthSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the stream URL. Possible statuses include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c>: The stream URL is valid and can start stream sessions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXPIRED</c>: The stream URL has passed its expiration time and can no longer start
        /// stream sessions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REVOKED</c>: The stream URL was revoked and can no longer start stream sessions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LIMIT_REACHED</c>: The stream URL has been used the maximum number of times and
        /// can no longer start stream sessions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StreamUrlStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about why the stream URL is in its current status. Amazon GameLift
        /// Streams populates this value when the status is <c>REVOKED</c>. Possible values include
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>userRevoked</c>: You revoked the stream URL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>revokedAndTerminatingSessions</c>: You revoked the stream URL and Amazon GameLift
        /// Streams is ending its running stream sessions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>revokedAndSessionsTerminated</c>: You revoked the stream URL and its running stream
        /// sessions have ended.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>streamGroupDeleted</c>: The stream group was deleted, which revoked the stream
        /// URL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>applicationDeleted</c>: The application was deleted, which revoked the stream
        /// URL.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StreamUrlStatusReason StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property StreamGroupArn. 
        /// <para>
        /// The stream group that runs the stream sessions.
        /// </para>
        ///  
        /// <para>
        /// This value is an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> that uniquely identifies the stream group resource. Example
        /// ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:streamgroup/sg-1AB2C3De4</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string StreamGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the StreamGroupArn property is set.
        /// </summary>
        internal bool IsSetStreamGroupArn() => this.StreamGroupArn != null;

        /// <summary>
        /// Gets and sets the property StreamUrl. 
        /// <para>
        /// The shareable stream URL. Distribute this URL to end users so that they can start
        /// and play a stream session in a hosted web player. Treat the stream URL as a secret.
        /// Anyone who has it can start a stream session until the stream URL expires, is revoked,
        /// or reaches its usage limit.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string StreamUrl { get; set; }

        /// <summary>
        /// Checks to see if the StreamUrl property is set.
        /// </summary>
        internal bool IsSetStreamUrl() => this.StreamUrl != null;

        /// <summary>
        /// Gets and sets the property StreamUrlId. 
        /// <para>
        /// The unique identifier for the stream URL resource, for example <c>su-1AB2C3De4</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string StreamUrlId { get; set; }

        /// <summary>
        /// Checks to see if the StreamUrlId property is set.
        /// </summary>
        internal bool IsSetStreamUrlId() => this.StreamUrlId != null;

        /// <summary>
        /// Gets and sets the property UsageLimit. 
        /// <para>
        /// The maximum number of times the stream URL can start a stream session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? UsageLimit { get; set; }

        /// <summary>
        /// Checks to see if the UsageLimit property is set.
        /// </summary>
        internal bool IsSetUsageLimit() => this.UsageLimit.HasValue;
    }
}
