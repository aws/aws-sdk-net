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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
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
namespace Amazon.PI.Model
{
    /// <summary>
    /// List of data objects which provide details about source metrics. This field can be
    /// used to determine the PI metric to render for the insight. This data type also includes
    /// static values for the metrics for the Insight that were calculated and included in
    /// text and annotations on the DB load chart.
    /// </summary>
    public partial class Data
    {
        private PerformanceInsightsMetric _performanceInsightsMetric;

        /// <summary>
        /// Gets and sets the property PerformanceInsightsMetric. 
        /// <para>
        /// This field determines the Performance Insights metric to render for the insight. The
        /// <c>name</c> field refers to a Performance Insights metric. 
        /// </para>
        /// </summary>
        public PerformanceInsightsMetric PerformanceInsightsMetric
        {
            get { return this._performanceInsightsMetric; }
            set { this._performanceInsightsMetric = value; }
        }

        // Check to see if PerformanceInsightsMetric property is set
        internal bool IsSetPerformanceInsightsMetric()
        {
            return this._performanceInsightsMetric != null;
        }

    }
}