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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// A complex type with the configuration information that determines the threshold and
    /// other conditions for when Internet Monitor creates a health event for an overall performance
    /// or availability issue, across an application's geographies.
    /// 
    ///  
    /// <para>
    /// Defines the percentages, for overall performance scores and availability scores for
    /// an application, that are the thresholds for when Amazon CloudWatch Internet Monitor
    /// creates a health event. You can override the defaults to set a custom threshold for
    /// overall performance or availability scores, or both.
    /// </para>
    ///  
    /// <para>
    /// You can also set thresholds for local health scores,, where Internet Monitor creates
    /// a health event when scores cross a threshold for one or more city-networks, in addition
    /// to creating an event when an overall score crosses a threshold.
    /// </para>
    ///  
    /// <para>
    /// If you don't set a health event threshold, the default value is 95%.
    /// </para>
    ///  
    /// <para>
    /// For local thresholds, you also set a minimum percentage of overall traffic that is
    /// impacted by an issue before Internet Monitor creates an event. In addition, you can
    /// disable local thresholds, for performance scores, availability scores, or both.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-overview.html#IMUpdateThresholdFromOverview">
    /// Change health event thresholds</a> in the Internet Monitor section of the <i>CloudWatch
    /// User Guide</i>.
    /// </para>
    /// </summary>
    public partial class HealthEventsConfig
    {
        private LocalHealthEventsConfig _availabilityLocalHealthEventsConfig;
        private double? _availabilityScoreThreshold;
        private LocalHealthEventsConfig _performanceLocalHealthEventsConfig;
        private double? _performanceScoreThreshold;

        /// <summary>
        /// Gets and sets the property AvailabilityLocalHealthEventsConfig. 
        /// <para>
        /// The configuration that determines the threshold and other conditions for when Internet
        /// Monitor creates a health event for a local availability issue.
        /// </para>
        /// </summary>
        public LocalHealthEventsConfig AvailabilityLocalHealthEventsConfig
        {
            get { return this._availabilityLocalHealthEventsConfig; }
            set { this._availabilityLocalHealthEventsConfig = value; }
        }

        // Check to see if AvailabilityLocalHealthEventsConfig property is set
        internal bool IsSetAvailabilityLocalHealthEventsConfig()
        {
            return this._availabilityLocalHealthEventsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityScoreThreshold. 
        /// <para>
        /// The health event threshold percentage set for availability scores.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double? AvailabilityScoreThreshold
        {
            get { return this._availabilityScoreThreshold; }
            set { this._availabilityScoreThreshold = value; }
        }

        // Check to see if AvailabilityScoreThreshold property is set
        internal bool IsSetAvailabilityScoreThreshold()
        {
            return this._availabilityScoreThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PerformanceLocalHealthEventsConfig. 
        /// <para>
        /// The configuration that determines the threshold and other conditions for when Internet
        /// Monitor creates a health event for a local performance issue.
        /// </para>
        /// </summary>
        public LocalHealthEventsConfig PerformanceLocalHealthEventsConfig
        {
            get { return this._performanceLocalHealthEventsConfig; }
            set { this._performanceLocalHealthEventsConfig = value; }
        }

        // Check to see if PerformanceLocalHealthEventsConfig property is set
        internal bool IsSetPerformanceLocalHealthEventsConfig()
        {
            return this._performanceLocalHealthEventsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property PerformanceScoreThreshold. 
        /// <para>
        /// The health event threshold percentage set for performance scores.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double? PerformanceScoreThreshold
        {
            get { return this._performanceScoreThreshold; }
            set { this._performanceScoreThreshold = value; }
        }

        // Check to see if PerformanceScoreThreshold property is set
        internal bool IsSetPerformanceScoreThreshold()
        {
            return this._performanceScoreThreshold.HasValue; 
        }

    }
}