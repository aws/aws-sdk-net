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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Represents a log stream, which is a sequence of log events from a single emitter of
    /// logs.
    /// </summary>
    public partial class LogStream
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the log stream.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the stream, expressed as the number of milliseconds after <c>Jan
        /// 1, 1970 00:00:00 UTC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FirstEventTimestamp. 
        /// <para>
        /// The time of the first event, expressed as the number of milliseconds after <c>Jan
        /// 1, 1970 00:00:00 UTC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public DateTime? FirstEventTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the FirstEventTimestamp property is set.
        /// </summary>
        internal bool IsSetFirstEventTimestamp() => this.FirstEventTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LastEventTimestamp. 
        /// <para>
        /// The time of the most recent log event in the log stream in CloudWatch Logs. This number
        /// is expressed as the number of milliseconds after <c>Jan 1, 1970 00:00:00 UTC</c>.
        /// The <c>lastEventTime</c> value updates on an eventual consistency basis. It typically
        /// updates in less than an hour from ingestion, but in rare situations might take longer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public DateTime? LastEventTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastEventTimestamp property is set.
        /// </summary>
        internal bool IsSetLastEventTimestamp() => this.LastEventTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LastIngestionTime. 
        /// <para>
        /// The ingestion time, expressed as the number of milliseconds after <c>Jan 1, 1970 00:00:00
        /// UTC</c> The <c>lastIngestionTime</c> value updates on an eventual consistency basis.
        /// It typically updates in less than an hour after ingestion, but in rare situations
        /// might take longer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public DateTime? LastIngestionTime { get; set; }

        /// <summary>
        /// Checks to see if the LastIngestionTime property is set.
        /// </summary>
        internal bool IsSetLastIngestionTime() => this.LastIngestionTime.HasValue;

        /// <summary>
        /// Gets and sets the property LogStreamName. 
        /// <para>
        /// The name of the log stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogStreamName { get; set; }

        /// <summary>
        /// Checks to see if the LogStreamName property is set.
        /// </summary>
        internal bool IsSetLogStreamName() => this.LogStreamName != null;

        /// <summary>
        /// Gets and sets the property StoredBytes. 
        /// <para>
        /// The number of bytes stored.
        /// </para>
        ///  
        /// <para>
        ///  <b>Important:</b> As of June 17, 2019, this parameter is no longer supported for
        /// log streams, and is always reported as zero. This change applies only to log streams.
        /// The <c>storedBytes</c> parameter for log groups is not affected.
        /// </para>
        /// </summary>
        [Obsolete("Starting on June 17, 2019, this parameter will be deprecated for log streams, and will be reported as zero. This change applies only to log streams. The storedBytes parameter for log groups is not affected.")]
        [AWSProperty(Min = 0)]
        public long? StoredBytes { get; set; }

        /// <summary>
        /// Checks to see if the StoredBytes property is set.
        /// </summary>
        internal bool IsSetStoredBytes() => this.StoredBytes.HasValue;

        /// <summary>
        /// Gets and sets the property UploadSequenceToken. 
        /// <para>
        /// The sequence token.
        /// </para>
        ///  <important> 
        /// <para>
        /// The sequence token is now ignored in <c>PutLogEvents</c> actions. <c>PutLogEvents</c>
        /// actions are always accepted regardless of receiving an invalid sequence token. You
        /// don't need to obtain <c>uploadSequenceToken</c> to use a <c>PutLogEvents</c> action.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string UploadSequenceToken { get; set; }

        /// <summary>
        /// Checks to see if the UploadSequenceToken property is set.
        /// </summary>
        internal bool IsSetUploadSequenceToken() => this.UploadSequenceToken != null;
    }
}
