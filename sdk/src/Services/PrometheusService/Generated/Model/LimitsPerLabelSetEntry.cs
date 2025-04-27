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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
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
namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// This structure contains the information about the limits that apply to time series
    /// that match one label set.
    /// </summary>
    public partial class LimitsPerLabelSetEntry
    {
        private long? _maxSeries;

        /// <summary>
        /// Gets and sets the property MaxSeries. 
        /// <para>
        /// The maximum number of active series that can be ingested that match this label set.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Setting this to 0 causes no label set limit to be enforced, but it does cause Amazon
        /// Managed Service for Prometheus to vend label set metrics to CloudWatch
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? MaxSeries
        {
            get { return this._maxSeries; }
            set { this._maxSeries = value; }
        }

        // Check to see if MaxSeries property is set
        internal bool IsSetMaxSeries()
        {
            return this._maxSeries.HasValue; 
        }

    }
}