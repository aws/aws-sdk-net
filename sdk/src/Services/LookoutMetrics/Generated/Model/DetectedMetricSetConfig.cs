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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// An inferred dataset configuration.
    /// </summary>
    public partial class DetectedMetricSetConfig
    {
        private DetectedField _metricSetFrequency;
        private DetectedMetricSource _metricSource;
        private DetectedField _offset;

        /// <summary>
        /// Gets and sets the property MetricSetFrequency. 
        /// <para>
        /// The dataset's interval.
        /// </para>
        /// </summary>
        public DetectedField MetricSetFrequency
        {
            get { return this._metricSetFrequency; }
            set { this._metricSetFrequency = value; }
        }

        // Check to see if MetricSetFrequency property is set
        internal bool IsSetMetricSetFrequency()
        {
            return this._metricSetFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property MetricSource. 
        /// <para>
        /// The dataset's data source.
        /// </para>
        /// </summary>
        public DetectedMetricSource MetricSource
        {
            get { return this._metricSource; }
            set { this._metricSource = value; }
        }

        // Check to see if MetricSource property is set
        internal bool IsSetMetricSource()
        {
            return this._metricSource != null;
        }

        /// <summary>
        /// Gets and sets the property Offset. 
        /// <para>
        /// The dataset's offset.
        /// </para>
        /// </summary>
        public DetectedField Offset
        {
            get { return this._offset; }
            set { this._offset = value; }
        }

        // Check to see if Offset property is set
        internal bool IsSetOffset()
        {
            return this._offset != null;
        }

    }
}