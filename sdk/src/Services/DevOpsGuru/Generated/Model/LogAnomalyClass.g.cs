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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Information about an anomalous log event found within a log group.
    /// </summary>
    public partial class LogAnomalyClass
    {
        /// <summary>
        /// Gets and sets the property Explanation. 
        /// <para>
        ///  The explanation for why the log event is considered an anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Explanation { get; set; }

        /// <summary>
        /// Checks to see if the Explanation property is set.
        /// </summary>
        internal bool IsSetExplanation() => this.Explanation != null;

        /// <summary>
        /// Gets and sets the property LogAnomalyToken. 
        /// <para>
        ///  The token where the anomaly was detected. This may refer to an exception or another
        /// location, or it may be blank for log anomalies such as format anomalies. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string LogAnomalyToken { get; set; }

        /// <summary>
        /// Checks to see if the LogAnomalyToken property is set.
        /// </summary>
        internal bool IsSetLogAnomalyToken() => this.LogAnomalyToken != null;

        /// <summary>
        /// Gets and sets the property LogAnomalyType. 
        /// <para>
        ///  The type of log anomaly that has been detected. 
        /// </para>
        /// </summary>
        public LogAnomalyType LogAnomalyType { get; set; }

        /// <summary>
        /// Checks to see if the LogAnomalyType property is set.
        /// </summary>
        internal bool IsSetLogAnomalyType() => this.LogAnomalyType != null;

        /// <summary>
        /// Gets and sets the property LogEventId. 
        /// <para>
        ///  The ID of the log event. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogEventId { get; set; }

        /// <summary>
        /// Checks to see if the LogEventId property is set.
        /// </summary>
        internal bool IsSetLogEventId() => this.LogEventId != null;

        /// <summary>
        /// Gets and sets the property LogEventTimestamp. 
        /// <para>
        ///  The time of the first occurrence of the anomalous log event. 
        /// </para>
        /// </summary>
        public DateTime? LogEventTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LogEventTimestamp property is set.
        /// </summary>
        internal bool IsSetLogEventTimestamp() => this.LogEventTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LogStreamName. 
        /// <para>
        ///  The name of the Amazon CloudWatch log stream that the anomalous log event belongs
        /// to. A log stream is a sequence of log events that share the same source. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogStreamName { get; set; }

        /// <summary>
        /// Checks to see if the LogStreamName property is set.
        /// </summary>
        internal bool IsSetLogStreamName() => this.LogStreamName != null;

        /// <summary>
        /// Gets and sets the property NumberOfLogLinesOccurrences. 
        /// <para>
        ///  The number of log lines where this anomalous log event occurs. 
        /// </para>
        /// </summary>
        public int? NumberOfLogLinesOccurrences { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfLogLinesOccurrences property is set.
        /// </summary>
        internal bool IsSetNumberOfLogLinesOccurrences() => this.NumberOfLogLinesOccurrences.HasValue;
    }
}
