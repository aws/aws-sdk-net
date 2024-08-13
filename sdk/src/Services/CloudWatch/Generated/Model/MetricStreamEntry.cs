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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// This structure contains the configuration information about one metric stream.
    /// </summary>
    public partial class MetricStreamEntry
    {
        private string _arn;
        private DateTime? _creationDate;
        private string _firehoseArn;
        private DateTime? _lastUpdateDate;
        private string _name;
        private MetricStreamOutputFormat _outputFormat;
        private string _state;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the metric stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date that the metric stream was originally created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FirehoseArn. 
        /// <para>
        /// The ARN of the Kinesis Firehose devlivery stream that is used for this metric stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string FirehoseArn
        {
            get { return this._firehoseArn; }
            set { this._firehoseArn = value; }
        }

        // Check to see if FirehoseArn property is set
        internal bool IsSetFirehoseArn()
        {
            return this._firehoseArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateDate. 
        /// <para>
        /// The date that the configuration of this metric stream was most recently updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateDate
        {
            get { return this._lastUpdateDate; }
            set { this._lastUpdateDate = value; }
        }

        // Check to see if LastUpdateDate property is set
        internal bool IsSetLastUpdateDate()
        {
            return this._lastUpdateDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the metric stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        /// The output format of this metric stream. Valid values are <c>json</c>, <c>opentelemetry1.0</c>,
        /// and <c>opentelemetry0.7</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public MetricStreamOutputFormat OutputFormat
        {
            get { return this._outputFormat; }
            set { this._outputFormat = value; }
        }

        // Check to see if OutputFormat property is set
        internal bool IsSetOutputFormat()
        {
            return this._outputFormat != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of this stream. Valid values are <c>running</c> and <c>stopped</c>.
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}