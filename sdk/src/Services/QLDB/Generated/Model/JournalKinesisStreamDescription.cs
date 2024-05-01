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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
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
namespace Amazon.QLDB.Model
{
    /// <summary>
    /// Information about an Amazon QLDB journal stream, including the Amazon Resource Name
    /// (ARN), stream name, creation time, current status, and the parameters of the original
    /// stream creation request.
    /// </summary>
    public partial class JournalKinesisStreamDescription
    {
        private string _arn;
        private DateTime? _creationTime;
        private ErrorCause _errorCause;
        private DateTime? _exclusiveEndTime;
        private DateTime? _inclusiveStartTime;
        private KinesisConfiguration _kinesisConfiguration;
        private string _ledgerName;
        private string _roleArn;
        private StreamStatus _status;
        private string _streamId;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the QLDB journal stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=1600)]
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
        /// The date and time, in epoch time format, when the QLDB journal stream was created.
        /// (Epoch time format is the number of seconds elapsed since 12:00:00 AM January 1, 1970
        /// UTC.)
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorCause. 
        /// <para>
        /// The error message that describes the reason that a stream has a status of <c>IMPAIRED</c>
        /// or <c>FAILED</c>. This is not applicable to streams that have other status values.
        /// </para>
        /// </summary>
        public ErrorCause ErrorCause
        {
            get { return this._errorCause; }
            set { this._errorCause = value; }
        }

        // Check to see if ErrorCause property is set
        internal bool IsSetErrorCause()
        {
            return this._errorCause != null;
        }

        /// <summary>
        /// Gets and sets the property ExclusiveEndTime. 
        /// <para>
        /// The exclusive date and time that specifies when the stream ends. If this parameter
        /// is undefined, the stream runs indefinitely until you cancel it.
        /// </para>
        /// </summary>
        public DateTime? ExclusiveEndTime
        {
            get { return this._exclusiveEndTime; }
            set { this._exclusiveEndTime = value; }
        }

        // Check to see if ExclusiveEndTime property is set
        internal bool IsSetExclusiveEndTime()
        {
            return this._exclusiveEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InclusiveStartTime. 
        /// <para>
        /// The inclusive start date and time from which to start streaming journal data.
        /// </para>
        /// </summary>
        public DateTime? InclusiveStartTime
        {
            get { return this._inclusiveStartTime; }
            set { this._inclusiveStartTime = value; }
        }

        // Check to see if InclusiveStartTime property is set
        internal bool IsSetInclusiveStartTime()
        {
            return this._inclusiveStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KinesisConfiguration. 
        /// <para>
        /// The configuration settings of the Amazon Kinesis Data Streams destination for a QLDB
        /// journal stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KinesisConfiguration KinesisConfiguration
        {
            get { return this._kinesisConfiguration; }
            set { this._kinesisConfiguration = value; }
        }

        // Check to see if KinesisConfiguration property is set
        internal bool IsSetKinesisConfiguration()
        {
            return this._kinesisConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LedgerName. 
        /// <para>
        /// The name of the ledger.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string LedgerName
        {
            get { return this._ledgerName; }
            set { this._ledgerName = value; }
        }

        // Check to see if LedgerName property is set
        internal bool IsSetLedgerName()
        {
            return this._ledgerName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that grants QLDB permissions for a
        /// journal stream to write data records to a Kinesis Data Streams resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1600)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the QLDB journal stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StreamStatus Status
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
        /// Gets and sets the property StreamId. 
        /// <para>
        /// The UUID (represented in Base62-encoded text) of the QLDB journal stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=22, Max=22)]
        public string StreamId
        {
            get { return this._streamId; }
            set { this._streamId = value; }
        }

        // Check to see if StreamId property is set
        internal bool IsSetStreamId()
        {
            return this._streamId != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The user-defined name of the QLDB journal stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

    }
}