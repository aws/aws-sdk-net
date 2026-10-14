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

namespace Amazon.AutoScalingPlans.Model
{
    /// <summary>
    /// Container for the parameters to the GetScalingPlanResourceForecastData operation.
    /// Retrieves the forecast data for a scalable resource. <para> Capacity forecasts are
    /// represented as predicted values, or data points, that are calculated using historical
    /// data points from a specified CloudWatch load metric. Data points are available for
    /// up to 56 days. </para>
    /// </summary>
    public partial class GetScalingPlanResourceForecastDataRequest : AmazonAutoScalingPlansRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The exclusive end time of the time range for the forecast data to get. The maximum
        /// time duration between the start and end time is seven days. 
        /// </para>
        ///  
        /// <para>
        /// Although this parameter can accept a date and time that is more than two days in the
        /// future, the availability of forecast data has limits. AWS Auto Scaling only issues
        /// forecasts for periods of two days in advance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ForecastDataType. 
        /// <para>
        /// The type of forecast data to get.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LoadForecast</c>: The load metric forecast. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CapacityForecast</c>: The capacity forecast. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ScheduledActionMinCapacity</c>: The minimum capacity for each scheduled scaling
        /// action. This data is calculated as the larger of two values: the capacity forecast
        /// or the minimum capacity in the scaling instruction.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ScheduledActionMaxCapacity</c>: The maximum capacity for each scheduled scaling
        /// action. The calculation used is determined by the predictive scaling maximum capacity
        /// behavior setting in the scaling instruction.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ForecastDataType ForecastDataType { get; set; }

        /// <summary>
        /// Checks to see if the ForecastDataType property is set.
        /// </summary>
        internal bool IsSetForecastDataType() => this.ForecastDataType != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource. This string consists of a prefix (<c>autoScalingGroup</c>)
        /// followed by the name of a specified Auto Scaling group (<c>my-asg</c>). Example: <c>autoScalingGroup/my-asg</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ScalableDimension. 
        /// <para>
        /// The scalable dimension for the resource. The only valid value is <c>autoscaling:autoScalingGroup:DesiredCapacity</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScalableDimension ScalableDimension { get; set; }

        /// <summary>
        /// Checks to see if the ScalableDimension property is set.
        /// </summary>
        internal bool IsSetScalableDimension() => this.ScalableDimension != null;

        /// <summary>
        /// Gets and sets the property ScalingPlanName. 
        /// <para>
        /// The name of the scaling plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ScalingPlanName { get; set; }

        /// <summary>
        /// Checks to see if the ScalingPlanName property is set.
        /// </summary>
        internal bool IsSetScalingPlanName() => this.ScalingPlanName != null;

        /// <summary>
        /// Gets and sets the property ScalingPlanVersion. 
        /// <para>
        /// The version number of the scaling plan. Currently, the only valid value is <c>1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ScalingPlanVersion { get; set; }

        /// <summary>
        /// Checks to see if the ScalingPlanVersion property is set.
        /// </summary>
        internal bool IsSetScalingPlanVersion() => this.ScalingPlanVersion.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceNamespace. 
        /// <para>
        /// The namespace of the AWS service. The only valid value is <c>autoscaling</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceNamespace ServiceNamespace { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNamespace property is set.
        /// </summary>
        internal bool IsSetServiceNamespace() => this.ServiceNamespace != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The inclusive start time of the time range for the forecast data to get. The date
        /// and time can be at most 56 days before the current date and time. 
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
