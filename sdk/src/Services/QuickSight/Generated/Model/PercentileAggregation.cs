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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// An aggregation based on the percentile of values in a dimension or measure.
    /// </summary>
    public partial class PercentileAggregation
    {
        private double? _percentileValue;

        /// <summary>
        /// Gets and sets the property PercentileValue. 
        /// <para>
        /// The percentile value. This value can be any numeric constant 0–100. A percentile value
        /// of 50 computes the median value of the measure.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double PercentileValue
        {
            get { return this._percentileValue.GetValueOrDefault(); }
            set { this._percentileValue = value; }
        }

        // Check to see if PercentileValue property is set
        internal bool IsSetPercentileValue()
        {
            return this._percentileValue.HasValue; 
        }

    }
}