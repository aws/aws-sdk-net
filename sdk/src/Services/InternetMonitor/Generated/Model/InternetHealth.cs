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
    /// Internet health includes measurements calculated by Amazon CloudWatch Internet Monitor
    /// about the performance and availability for your application on the internet. Amazon
    /// Web Services has substantial historical data about internet performance and availability
    /// between Amazon Web Services services and different network providers and geographies.
    /// By applying statistical analysis to the data, Internet Monitor can detect when the
    /// performance and availability for your application has dropped, compared to an estimated
    /// baseline that's already calculated. To make it easier to see those drops, we report
    /// that information to you in the form of health scores: a performance score and an availability
    /// score.
    /// </summary>
    public partial class InternetHealth
    {
        private AvailabilityMeasurement _availability;
        private PerformanceMeasurement _performance;

        /// <summary>
        /// Gets and sets the property Availability. 
        /// <para>
        /// Availability in Internet Monitor represents the estimated percentage of traffic that
        /// is not seeing an availability drop. For example, an availability score of 99% for
        /// an end user and service location pair is equivalent to 1% of the traffic experiencing
        /// an availability drop for that pair.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-inside-internet-monitor.html#IMExperienceScores">
        /// How Internet Monitor calculates performance and availability scores</a> in the Amazon
        /// CloudWatch Internet Monitor section of the Amazon CloudWatch User Guide.
        /// </para>
        /// </summary>
        public AvailabilityMeasurement Availability
        {
            get { return this._availability; }
            set { this._availability = value; }
        }

        // Check to see if Availability property is set
        internal bool IsSetAvailability()
        {
            return this._availability != null;
        }

        /// <summary>
        /// Gets and sets the property Performance. 
        /// <para>
        /// Performance in Internet Monitor represents the estimated percentage of traffic that
        /// is not seeing a performance drop. For example, a performance score of 99% for an end
        /// user and service location pair is equivalent to 1% of the traffic experiencing a performance
        /// drop for that pair.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-inside-internet-monitor.html#IMExperienceScores">
        /// How Internet Monitor calculates performance and availability scores</a> in the Amazon
        /// CloudWatch Internet Monitor section of the Amazon CloudWatch User Guide.
        /// </para>
        /// </summary>
        public PerformanceMeasurement Performance
        {
            get { return this._performance; }
            set { this._performance = value; }
        }

        // Check to see if Performance property is set
        internal bool IsSetPerformance()
        {
            return this._performance != null;
        }

    }
}