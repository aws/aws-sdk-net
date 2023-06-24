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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRealtimeLogConfig operation.
    /// Updates a real-time log configuration.
    /// 
    ///  
    /// <para>
    /// When you update a real-time log configuration, all the parameters are updated with
    /// the values provided in the request. You cannot update some parameters independent
    /// of others. To update a real-time log configuration:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Call <code>GetRealtimeLogConfig</code> to get the current real-time log configuration.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Locally modify the parameters in the real-time log configuration that you want to
    /// update.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Call this API (<code>UpdateRealtimeLogConfig</code>) by providing the entire real-time
    /// log configuration, including the parameters that you modified and those that you didn't.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// You cannot update a real-time log configuration's <code>Name</code> or <code>ARN</code>.
    /// </para>
    /// </summary>
    public partial class UpdateRealtimeLogConfigRequest : AmazonCloudFrontRequest
    {
        private string _arn;
        private List<EndPoint> _endPoints = new List<EndPoint>();
        private List<string> _fields = new List<string>();
        private string _name;
        private long? _samplingRate;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) for this real-time log configuration.
        /// </para>
        /// </summary>
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
        /// log data.
        /// </para>
        /// </summary>
        public List<EndPoint> EndPoints
        {
            get { return this._endPoints; }
            set { this._endPoints = value; }
        }

        // Check to see if EndPoints property is set
        internal bool IsSetEndPoints()
        {
            return this._endPoints != null && this._endPoints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// A list of fields to include in each real-time log record.
        /// </para>
        ///  
        /// <para>
        /// For more information about fields, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/real-time-logs.html#understand-real-time-log-config-fields">Real-time
        /// log configuration fields</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public List<string> Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null && this._fields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for this real-time log configuration.
        /// </para>
        /// </summary>
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
        /// You must provide an integer between 1 and 100, inclusive.
        /// </para>
        /// </summary>
        public long SamplingRate
        {
            get { return this._samplingRate.GetValueOrDefault(); }
            set { this._samplingRate = value; }
        }

        // Check to see if SamplingRate property is set
        internal bool IsSetSamplingRate()
        {
            return this._samplingRate.HasValue; 
        }

    }
}