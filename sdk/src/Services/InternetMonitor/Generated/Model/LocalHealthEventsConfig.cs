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
    /// other conditions for when Internet Monitor creates a health event for a local performance
    /// or availability issue, when scores cross a threshold for one or more city-networks.
    /// 
    ///  
    /// <para>
    /// Defines the percentages, for performance scores or availability scores, that are the
    /// local thresholds for when Amazon CloudWatch Internet Monitor creates a health event.
    /// Also defines whether a local threshold is enabled or disabled, and the minimum percentage
    /// of overall traffic that must be impacted by an issue before Internet Monitor creates
    /// an event when a threshold is crossed for a local health score.
    /// </para>
    ///  
    /// <para>
    /// If you don't set a local health event threshold, the default value is 60%.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-overview.html#IMUpdateThresholdFromOverview">
    /// Change health event thresholds</a> in the Internet Monitor section of the <i>CloudWatch
    /// User Guide</i>.
    /// </para>
    /// </summary>
    public partial class LocalHealthEventsConfig
    {
        private double? _healthScoreThreshold;
        private double? _minTrafficImpact;
        private LocalHealthEventsConfigStatus _status;

        /// <summary>
        /// Gets and sets the property HealthScoreThreshold. 
        /// <para>
        /// The health event threshold percentage set for a local health score.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double? HealthScoreThreshold
        {
            get { return this._healthScoreThreshold; }
            set { this._healthScoreThreshold = value; }
        }

        // Check to see if HealthScoreThreshold property is set
        internal bool IsSetHealthScoreThreshold()
        {
            return this._healthScoreThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinTrafficImpact. 
        /// <para>
        /// The minimum percentage of overall traffic for an application that must be impacted
        /// by an issue before Internet Monitor creates an event when a threshold is crossed for
        /// a local health score.
        /// </para>
        ///  
        /// <para>
        /// If you don't set a minimum traffic impact threshold, the default value is 0.1%.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double? MinTrafficImpact
        {
            get { return this._minTrafficImpact; }
            set { this._minTrafficImpact = value; }
        }

        // Check to see if MinTrafficImpact property is set
        internal bool IsSetMinTrafficImpact()
        {
            return this._minTrafficImpact.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of whether Internet Monitor creates a health event based on a threshold
        /// percentage set for a local health score. The status can be <c>ENABLED</c> or <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public LocalHealthEventsConfigStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}