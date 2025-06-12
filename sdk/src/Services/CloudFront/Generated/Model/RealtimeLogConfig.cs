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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A real-time log configuration.
    /// </summary>
    public partial class RealtimeLogConfig
    {
        private string _arn;
        private List<EndPoint> _endPoints = AWSConfigs.InitializeCollections ? new List<EndPoint>() : null;
        private List<string> _fields = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private long? _samplingRate;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of this real-time log configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property EndPoints. 
        /// <para>
        /// Contains information about the Amazon Kinesis data stream where you are sending real-time
        /// log data for this real-time log configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<EndPoint> EndPoints
        {
            get { return this._endPoints; }
            set { this._endPoints = value; }
        }

        // Check to see if EndPoints property is set
        internal bool IsSetEndPoints()
        {
            return this._endPoints != null && (this._endPoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// A list of fields that are included in each real-time log record. In an API response,
        /// the fields are provided in the same order in which they are sent to the Amazon Kinesis
        /// data stream.
        /// </para>
        ///  
        /// <para>
        /// For more information about fields, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/real-time-logs.html#understand-real-time-log-config-fields">Real-time
        /// log configuration fields</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null && (this._fields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique name of this real-time log configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SamplingRate. 
        /// <para>
        /// The sampling rate for this real-time log configuration. The sampling rate determines
        /// the percentage of viewer requests that are represented in the real-time log data.
        /// The sampling rate is an integer between 1 and 100, inclusive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? SamplingRate
        {
            get { return this._samplingRate; }
            set { this._samplingRate = value; }
        }

        // Check to see if SamplingRate property is set
        internal bool IsSetSamplingRate()
        {
            return this._samplingRate.HasValue; 
        }

    }
}