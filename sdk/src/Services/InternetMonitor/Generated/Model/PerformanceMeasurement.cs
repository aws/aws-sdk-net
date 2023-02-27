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
    /// Measurements about the performance for your application on the internet calculated
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
    public partial class PerformanceMeasurement
    {
        private double? _experienceScore;
        private double? _percentOfClientLocationImpacted;
        private double? _percentOfTotalTrafficImpacted;
        private RoundTripTime _roundTripTime;

        /// <summary>
        /// Gets and sets the property ExperienceScore. 
        /// <para>
        /// Experience scores, or health scores, are calculated for different geographic and network
        /// provider combinations (that is, different granularities) and also totaled into global
        /// scores. If you view performance or availability scores without filtering for any specific
        /// geography or service provider, Amazon CloudWatch Internet Monitor provides global
        /// health scores.
        /// </para>
        ///  
        /// <para>
        /// The Amazon CloudWatch Internet Monitor chapter in the CloudWatch User Guide includes
        /// detailed information about how Internet Monitor calculates health scores, including
        /// performance and availability scores, and when it creates and resolves health events.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-inside-internet-monitor.html#IMExperienceScores">
        /// How Amazon Web Services calculates performance and availability scores</a> in the
        /// Amazon CloudWatch Internet Monitor section of the CloudWatch User Guide.
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
        /// How much performance impact was caused by a health event at a client location. For
        /// performance, this is the percentage of how much latency increased during the event
        /// compared to typical performance for traffic, from this client location to an Amazon
        /// Web Services location, using a specific client network. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-inside-internet-monitor.html#IMHealthEventStartStop">
        /// When Amazon Web Services creates and resolves health events</a> in the Amazon CloudWatch
        /// Internet Monitor section of the CloudWatch User Guide.
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
        /// How much performance impact was caused by a health event for total traffic globally.
        /// For performance, this is the percentage of how much latency increased during the event
        /// compared to typical performance for your application traffic globally. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-inside-internet-monitor.html#IMHealthEventStartStop">
        /// When Amazon Web Services creates and resolves health events</a> in the Amazon CloudWatch
        /// Internet Monitor section of the CloudWatch User Guide.
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

        /// <summary>
        /// Gets and sets the property RoundTripTime. 
        /// <para>
        /// This is the percentage of how much round-trip time increased during the event compared
        /// to typical round-trip time for your application for traffic. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-inside-internet-monitor.html#IMHealthEventStartStop">
        /// When Amazon Web Services creates and resolves health events</a> in the Amazon CloudWatch
        /// Internet Monitor section of the CloudWatch User Guide.
        /// </para>
        /// </summary>
        public RoundTripTime RoundTripTime
        {
            get { return this._roundTripTime; }
            set { this._roundTripTime = value; }
        }

        // Check to see if RoundTripTime property is set
        internal bool IsSetRoundTripTime()
        {
            return this._roundTripTime != null;
        }

    }
}