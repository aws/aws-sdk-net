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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// A <code>GetPredictiveScalingForecast</code> call returns the capacity forecast for
    /// a predictive scaling policy. This structure includes the data points for that capacity
    /// forecast, along with the timestamps of those data points.
    /// </summary>
    public partial class CapacityForecast
    {
        private List<DateTime> _timestamps = new List<DateTime>();
        private List<double> _values = new List<double>();

        /// <summary>
        /// Gets and sets the property Timestamps. 
        /// <para>
        /// The time stamps for the data points, in UTC format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DateTime> Timestamps
        {
            get { return this._timestamps; }
            set { this._timestamps = value; }
        }

        // Check to see if Timestamps property is set
        internal bool IsSetTimestamps()
        {
            return this._timestamps != null && this._timestamps.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values of the data points.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<double> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}