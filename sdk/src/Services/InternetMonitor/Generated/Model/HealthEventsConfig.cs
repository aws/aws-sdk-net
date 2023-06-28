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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// A complex type for the configuration. Defines the health event threshold percentages,
    /// for performance score and availability score. Amazon CloudWatch Internet Monitor creates
    /// a health event when there's an internet issue that affects your application end users
    /// where a health score percentage is at or below a set threshold. If you don't set a
    /// health event threshold, the default value is 95%.
    /// </summary>
    public partial class HealthEventsConfig
    {
        private double? _availabilityScoreThreshold;
        private double? _performanceScoreThreshold;

        /// <summary>
        /// Gets and sets the property AvailabilityScoreThreshold. 
        /// <para>
        /// The health event threshold percentage set for availability scores.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double AvailabilityScoreThreshold
        {
            get { return this._availabilityScoreThreshold.GetValueOrDefault(); }
            set { this._availabilityScoreThreshold = value; }
        }

        // Check to see if AvailabilityScoreThreshold property is set
        internal bool IsSetAvailabilityScoreThreshold()
        {
            return this._availabilityScoreThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PerformanceScoreThreshold. 
        /// <para>
        /// The health event threshold percentage set for performance scores.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double PerformanceScoreThreshold
        {
            get { return this._performanceScoreThreshold.GetValueOrDefault(); }
            set { this._performanceScoreThreshold = value; }
        }

        // Check to see if PerformanceScoreThreshold property is set
        internal bool IsSetPerformanceScoreThreshold()
        {
            return this._performanceScoreThreshold.HasValue; 
        }

    }
}