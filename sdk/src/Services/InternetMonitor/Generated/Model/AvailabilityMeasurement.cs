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
    /// Measurements about the availability for your application on the internet, calculated
    /// by Amazon CloudWatch Internet Monitor. Amazon Web Services has substantial historical
    /// data about internet performance and availability between Amazon Web Services services
    /// and different network providers and geographies. By applying statistical analysis
    /// to the data, Internet Monitor can detect when the performance and availability for
    /// your application has dropped, compared to an estimated baseline that's already calculated.
    /// To make it easier to see those drops, we report that information to you in the form
    /// of health scores: a performance score and an availability score.
    /// 
    ///  
    /// <para>
    /// Availability in Internet Monitor represents the estimated percentage of traffic that
    /// is not seeing an availability drop. For example, an availability score of 99% for
    /// an end user and service location pair is equivalent to 1% of the traffic experiencing
    /// an availability drop for that pair.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-inside-internet-monitor.html#IMExperienceScores">How
    /// Internet Monitor calculates performance and availability scores</a> in the Amazon
    /// CloudWatch Internet Monitor section of the <i>Amazon CloudWatch User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AvailabilityMeasurement
    {
        private double? _experienceScore;
        private double? _percentOfClientLocationImpacted;
        private double? _percentOfTotalTrafficImpacted;

        /// <summary>
        /// Gets and sets the property ExperienceScore. 
        /// <para>
        /// Experience scores, or health scores are calculated for different geographic and network
        /// provider combinations (that is, different granularities) and also summed into global
        /// scores. If you view performance or availability scores without filtering for any specific
        /// geography or service provider, Amazon CloudWatch Internet Monitor provides global
        /// health scores.
        /// </para>
        ///  
        /// <para>
        /// The Amazon CloudWatch Internet Monitor chapter in the <i>CloudWatch User Guide</i>
        /// includes detailed information about how Internet Monitor calculates health scores,
        /// including performance and availability scores, and when it creates and resolves health
        /// events. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-inside-internet-monitor.html#IMExperienceScores">How
        /// Amazon Web Services calculates performance and availability scores</a> in the Amazon
        /// CloudWatch Internet Monitor section of the <i>CloudWatch User Guide</i>.
        /// </para>
        /// </summary>
        public double ExperienceScore
        {
            get { return this._experienceScore.GetValueOrDefault(); }
            set { this._experienceScore = value; }
        }

        // Check to see if ExperienceScore property is set
        internal bool IsSetExperienceScore()
        {
            return this._experienceScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PercentOfClientLocationImpacted. 
        /// <para>
        /// The percentage of impact caused by a health event for client location traffic globally.
        /// </para>
        ///  
        /// <para>
        /// For information about how Internet Monitor calculates impact, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-inside-internet-monitor.html">Inside
        /// Internet Monitor</a> in the Amazon CloudWatch Internet Monitor section of the Amazon
        /// CloudWatch User Guide.
        /// </para>
        /// </summary>
        public double PercentOfClientLocationImpacted
        {
            get { return this._percentOfClientLocationImpacted.GetValueOrDefault(); }
            set { this._percentOfClientLocationImpacted = value; }
        }

        // Check to see if PercentOfClientLocationImpacted property is set
        internal bool IsSetPercentOfClientLocationImpacted()
        {
            return this._percentOfClientLocationImpacted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PercentOfTotalTrafficImpacted. 
        /// <para>
        /// The percentage of impact caused by a health event for total traffic globally.
        /// </para>
        ///  
        /// <para>
        /// For information about how Internet Monitor calculates impact, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-inside-internet-monitor.html">Inside
        /// Internet Monitor</a> in the Amazon CloudWatch Internet Monitor section of the Amazon
        /// CloudWatch User Guide.
        /// </para>
        /// </summary>
        public double PercentOfTotalTrafficImpacted
        {
            get { return this._percentOfTotalTrafficImpacted.GetValueOrDefault(); }
            set { this._percentOfTotalTrafficImpacted = value; }
        }

        // Check to see if PercentOfTotalTrafficImpacted property is set
        internal bool IsSetPercentOfTotalTrafficImpacted()
        {
            return this._percentOfTotalTrafficImpacted.HasValue; 
        }

    }
}