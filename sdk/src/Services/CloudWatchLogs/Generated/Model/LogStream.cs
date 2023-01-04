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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Represents a log stream, which is a sequence of log events from a single emitter of
    /// logs.
    /// </summary>
    public partial class LogStream
    {
        private string _arn;
        private DateTime? _creationTime;
        private DateTime? _firstEventTimestamp;
        private DateTime? _lastEventTimestamp;
        private DateTime? _lastIngestionTime;
        private string _logStreamName;
        private long? _storedBytes;
        private string _uploadSequenceToken;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the log stream.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the stream, expressed as the number of milliseconds after <code>Jan
        /// 1, 1970 00:00:00 UTC</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FirstEventTimestamp. 
        /// <para>
        /// The time of the first event, expressed as the number of milliseconds after <code>Jan
        /// 1, 1970 00:00:00 UTC</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public DateTime FirstEventTimestamp
        {
            get { return this._firstEventTimestamp.GetValueOrDefault(); }
            set { this._firstEventTimestamp = value; }
        }

        // Check to see if FirstEventTimestamp property is set
        internal bool IsSetFirstEventTimestamp()
        {
            return this._firstEventTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastEventTimestamp. 
        /// <para>
        /// The time of the most recent log event in the log stream in CloudWatch Logs. This number
        /// is expressed as the number of milliseconds after <code>Jan 1, 1970 00:00:00 UTC</code>.
        /// The <code>lastEventTime</code> value updates on an eventual consistency basis. It
        /// typically updates in less than an hour from ingestion, but in rare situations might
        /// take longer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public DateTime LastEventTimestamp
        {
            get { return this._lastEventTimestamp.GetValueOrDefault(); }
            set { this._lastEventTimestamp = value; }
        }

        // Check to see if LastEventTimestamp property is set
        internal bool IsSetLastEventTimestamp()
        {
            return this._lastEventTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastIngestionTime. 
        /// <para>
        /// The ingestion time, expressed as the number of milliseconds after <code>Jan 1, 1970
        /// 00:00:00 UTC</code> The <code>lastIngestionTime</code> value updates on an eventual
        /// consistency basis. It typically updates in less than an hour after ingestion, but
        /// in rare situations might take longer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public DateTime LastIngestionTime
        {
            get { return this._lastIngestionTime.GetValueOrDefault(); }
            set { this._lastIngestionTime = value; }
        }

        // Check to see if LastIngestionTime property is set
        internal bool IsSetLastIngestionTime()
        {
            return this._lastIngestionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogStreamName. 
        /// <para>
        /// The name of the log stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LogStreamName
        {
            get { return this._logStreamName; }
            set { this._logStreamName = value; }
        }

        // Check to see if LogStreamName property is set
        internal bool IsSetLogStreamName()
        {
            return this._logStreamName != null;
        }

        /// <summary>
        /// Gets and sets the property StoredBytes. 
        /// <para>
        /// The number of bytes stored.
        /// </para>
        ///  
        /// <para>
        ///  <b>Important:</b> As of June 17, 2019, this parameter is no longer supported for
        /// log streams, and is always reported as zero. This change applies only to log streams.
        /// The <code>storedBytes</code> parameter for log groups is not affected.
        /// </para>
        /// </summary>
        [Obsolete("Starting on June 17, 2019, this parameter will be deprecated for log streams, and will be reported as zero. This change applies only to log streams. The storedBytes parameter for log groups is not affected.")]
        [AWSProperty(Min=0)]
        public long StoredBytes
        {
            get { return this._storedBytes.GetValueOrDefault(); }
            set { this._storedBytes = value; }
        }

        // Check to see if StoredBytes property is set
        internal bool IsSetStoredBytes()
        {
            return this._storedBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UploadSequenceToken. 
        /// <para>
        /// The sequence token.
        /// </para>
        ///  <important> 
        /// <para>
        /// The sequence token is now ignored in <code>PutLogEvents</code> actions. <code>PutLogEvents</code>
        /// actions are always accepted regardless of receiving an invalid sequence token. You
        /// don't need to obtain <code>uploadSequenceToken</code> to use a <code>PutLogEvents</code>
        /// action.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=1)]
        public string UploadSequenceToken
        {
            get { return this._uploadSequenceToken; }
            set { this._uploadSequenceToken = value; }
        }

        // Check to see if UploadSequenceToken property is set
        internal bool IsSetUploadSequenceToken()
        {
            return this._uploadSequenceToken != null;
        }

    }
}