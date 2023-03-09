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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about the metric.
    /// </summary>
    public partial class MetricV2
    {
        private List<MetricFilterV2> _metricFilters = new List<MetricFilterV2>();
        private string _name;
        private List<ThresholdV2> _threshold = new List<ThresholdV2>();

        /// <summary>
        /// Gets and sets the property MetricFilters. 
        /// <para>
        /// Contains the filters to be used when returning data.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2)]
        public List<MetricFilterV2> MetricFilters
        {
            get { return this._metricFilters; }
            set { this._metricFilters = value; }
        }

        // Check to see if MetricFilters property is set
        internal bool IsSetMetricFilters()
        {
            return this._metricFilters != null && this._metricFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the metric.
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
        /// Gets and sets the property Threshold. 
        /// <para>
        /// Contains information about the threshold for service level metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<ThresholdV2> Threshold
        {
            get { return this._threshold; }
            set { this._threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this._threshold != null && this._threshold.Count > 0; 
        }

    }
}