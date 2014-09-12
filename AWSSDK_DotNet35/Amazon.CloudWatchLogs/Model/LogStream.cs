/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// A log stream is sequence of log events that share the same emitter.
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
        /// </summary>
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
        /// </summary>
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
        /// </summary>
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
        /// </summary>
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
        /// </summary>
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
        /// </summary>
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
        /// </summary>
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