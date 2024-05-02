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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Information about an anomalous log event found within a log group.
    /// </summary>
    public partial class LogAnomalyClass
    {
        private string _explanation;
        private string _logAnomalyToken;
        private LogAnomalyType _logAnomalyType;
        private string _logEventId;
        private DateTime? _logEventTimestamp;
        private string _logStreamName;
        private int? _numberOfLogLinesOccurrences;

        /// <summary>
        /// Gets and sets the property Explanation. 
        /// <para>
        ///  The explanation for why the log event is considered an anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Explanation
        {
            get { return this._explanation; }
            set { this._explanation = value; }
        }

        // Check to see if Explanation property is set
        internal bool IsSetExplanation()
        {
            return this._explanation != null;
        }

        /// <summary>
        /// Gets and sets the property LogAnomalyToken. 
        /// <para>
        ///  The token where the anomaly was detected. This may refer to an exception or another
        /// location, or it may be blank for log anomalies such as format anomalies. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string LogAnomalyToken
        {
            get { return this._logAnomalyToken; }
            set { this._logAnomalyToken = value; }
        }

        // Check to see if LogAnomalyToken property is set
        internal bool IsSetLogAnomalyToken()
        {
            return this._logAnomalyToken != null;
        }

        /// <summary>
        /// Gets and sets the property LogAnomalyType. 
        /// <para>
        ///  The type of log anomaly that has been detected. 
        /// </para>
        /// </summary>
        public LogAnomalyType LogAnomalyType
        {
            get { return this._logAnomalyType; }
            set { this._logAnomalyType = value; }
        }

        // Check to see if LogAnomalyType property is set
        internal bool IsSetLogAnomalyType()
        {
            return this._logAnomalyType != null;
        }

        /// <summary>
        /// Gets and sets the property LogEventId. 
        /// <para>
        ///  The ID of the log event. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LogEventId
        {
            get { return this._logEventId; }
            set { this._logEventId = value; }
        }

        // Check to see if LogEventId property is set
        internal bool IsSetLogEventId()
        {
            return this._logEventId != null;
        }

        /// <summary>
        /// Gets and sets the property LogEventTimestamp. 
        /// <para>
        ///  The time of the first occurrence of the anomalous log event. 
        /// </para>
        /// </summary>
        public DateTime? LogEventTimestamp
        {
            get { return this._logEventTimestamp; }
            set { this._logEventTimestamp = value; }
        }

        // Check to see if LogEventTimestamp property is set
        internal bool IsSetLogEventTimestamp()
        {
            return this._logEventTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogStreamName. 
        /// <para>
        ///  The name of the Amazon CloudWatch log stream that the anomalous log event belongs
        /// to. A log stream is a sequence of log events that share the same source. 
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
        /// Gets and sets the property NumberOfLogLinesOccurrences. 
        /// <para>
        ///  The number of log lines where this anomalous log event occurs. 
        /// </para>
        /// </summary>
        public int? NumberOfLogLinesOccurrences
        {
            get { return this._numberOfLogLinesOccurrences; }
            set { this._numberOfLogLinesOccurrences = value; }
        }

        // Check to see if NumberOfLogLinesOccurrences property is set
        internal bool IsSetNumberOfLogLinesOccurrences()
        {
            return this._numberOfLogLinesOccurrences.HasValue; 
        }

    }
}