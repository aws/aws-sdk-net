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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the GetPredictiveScalingForecast operation. Retrieves
    /// the forecast data for a predictive scaling policy. <para> Load forecasts are predictions
    /// of the hourly load values using historical load data from CloudWatch and an analysis
    /// of historical trends. Capacity forecasts are represented as predicted values for the
    /// minimum capacity that is needed on an hourly basis, based on the hourly load forecast.
    /// </para> <para> A minimum of 24 hours of data is required to create the initial forecasts.
    /// However, having a full 14 days of historical data results in more accurate forecasts.
    /// </para> <para> For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-predictive-scaling.html">Predictive
    /// scaling for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetPredictiveScalingForecastRequest : AmazonAutoScalingRequest
    {
        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string AutoScalingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingGroupName property is set.
        /// </summary>
        internal bool IsSetAutoScalingGroupName() => this.AutoScalingGroupName != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The exclusive end time of the time range for the forecast data to get. The maximum
        /// time duration between the start and end time is 30 days. 
        /// </para>
        ///  
        /// <para>
        /// Although this parameter can accept a date and time that is more than two days in the
        /// future, the availability of forecast data has limits. Amazon EC2 Auto Scaling only
        /// issues forecasts for periods of two days in advance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The inclusive start time of the time range for the forecast data to get. At most,
        /// the date and time can be one year before the current date and time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
