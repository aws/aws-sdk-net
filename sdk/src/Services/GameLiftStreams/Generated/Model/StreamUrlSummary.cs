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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
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
    /// Describes a stream URL. This is a summary view that omits the full configuration,
    /// such as launch arguments and display settings. To retrieve the complete configuration,
    /// call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetStreamUrl.html">GetStreamUrl</a>.
    /// </summary>
    public partial class StreamUrlSummary
    {
        private string _applicationArn;
        private string _arn;
        private DateTime? _createdAt;
        private string _description;
        private DateTime? _expiresAt;
        private int? _remainingUses;
        private int? _sessionLengthSeconds;
        private StreamUrlStatus _status;
        private StreamUrlStatusReason _statusReason;
        private string _streamGroupArn;
        private string _streamUrl;
        private string _streamUrlId;
        private int? _usageLimit;

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
        [AWSProperty(Min=1, Max=128)]
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> that uniquely identifies the stream URL across all Amazon
        /// Web Services Regions. Format is <c>arn:aws:gameliftstreams:[AWS Region]:[AWS account]:streamurl/[stream
        /// group resource ID]/[stream URL resource ID]</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// A timestamp that indicates when this resource was created. Timestamps are expressed
        /// using in ISO8601 format, such as: <c>2022-12-27T22:29:40+00:00</c> (UTC).
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The descriptive label for the stream URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=80)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The date and time when the stream URL expires and stops accepting new stream sessions.
        /// Timestamps are expressed using in ISO8601 format, such as: <c>2022-12-27T22:29:40+00:00</c>
        /// (UTC).
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt
        {
            get { return this._expiresAt; }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemainingUses. 
        /// <para>
        /// The number of times the stream URL can still be used to start a stream session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? RemainingUses
        {
            get { return this._remainingUses; }
            set { this._remainingUses = value; }
        }

        // Check to see if RemainingUses property is set
        internal bool IsSetRemainingUses()
        {
            return this._remainingUses.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionLengthSeconds. 
        /// <para>
        /// The maximum length of time, in seconds, that a stream session started from this stream
        /// URL can run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=86400)]
        public int? SessionLengthSeconds
        {
            get { return this._sessionLengthSeconds; }
            set { this._sessionLengthSeconds = value; }
        }

        // Check to see if SessionLengthSeconds property is set
        internal bool IsSetSessionLengthSeconds()
        {
            return this._sessionLengthSeconds.HasValue; 
        }

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
        public StreamUrlStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

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
        public StreamUrlStatusReason StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

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
        [AWSProperty(Min=1, Max=128)]
        public string StreamGroupArn
        {
            get { return this._streamGroupArn; }
            set { this._streamGroupArn = value; }
        }

        // Check to see if StreamGroupArn property is set
        internal bool IsSetStreamGroupArn()
        {
            return this._streamGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property StreamUrl. 
        /// <para>
        /// The shareable stream URL. Distribute this URL to end users so that they can start
        /// and play a stream session in a hosted web player. Treat the stream URL as a secret.
        /// Anyone who has it can start a stream session until the stream URL expires, is revoked,
        /// or reaches its usage limit.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2048)]
        public string StreamUrl
        {
            get { return this._streamUrl; }
            set { this._streamUrl = value; }
        }

        // Check to see if StreamUrl property is set
        internal bool IsSetStreamUrl()
        {
            return this._streamUrl != null;
        }

        /// <summary>
        /// Gets and sets the property StreamUrlId. 
        /// <para>
        /// The unique identifier for the stream URL resource, for example <c>su-1AB2C3De4</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string StreamUrlId
        {
            get { return this._streamUrlId; }
            set { this._streamUrlId = value; }
        }

        // Check to see if StreamUrlId property is set
        internal bool IsSetStreamUrlId()
        {
            return this._streamUrlId != null;
        }

        /// <summary>
        /// Gets and sets the property UsageLimit. 
        /// <para>
        /// The maximum number of times the stream URL can start a stream session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? UsageLimit
        {
            get { return this._usageLimit; }
            set { this._usageLimit = value; }
        }

        // Check to see if UsageLimit property is set
        internal bool IsSetUsageLimit()
        {
            return this._usageLimit.HasValue; 
        }

    }
}