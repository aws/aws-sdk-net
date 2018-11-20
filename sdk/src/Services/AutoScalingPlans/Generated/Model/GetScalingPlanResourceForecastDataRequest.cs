/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScalingPlans.Model
{
    /// <summary>
    /// Container for the parameters to the GetScalingPlanResourceForecastData operation.
    /// Retrieves the forecast data for a scalable resource.
    /// 
    ///  
    /// <para>
    /// Capacity forecasts are represented as predicted values, or data points, that are calculated
    /// using historical data points from a specified CloudWatch load metric. Data points
    /// are available for up to 56 days. 
    /// </para>
    /// </summary>
    public partial class GetScalingPlanResourceForecastDataRequest : AmazonAutoScalingPlansRequest
    {
        private DateTime? _endTime;
        private ForecastDataType _forecastDataType;
        private string _resourceId;
        private ScalableDimension _scalableDimension;
        private string _scalingPlanName;
        private long? _scalingPlanVersion;
        private ServiceNamespace _serviceNamespace;
        private DateTime? _startTime;

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
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForecastDataType. 
        /// <para>
        /// The type of forecast data to get.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>LoadForecast</code>: The load metric forecast. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CapacityForecast</code>: The capacity forecast. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ScheduledActionMinCapacity</code>: The minimum capacity for each scheduled
        /// scaling action. This data is calculated as the larger of two values: the capacity
        /// forecast or the minimum capacity in the scaling instruction.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ScheduledActionMaxCapacity</code>: The maximum capacity for each scheduled
        /// scaling action. The calculation used is determined by the predictive scaling maximum
        /// capacity behavior setting in the scaling instruction.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ForecastDataType ForecastDataType
        {
            get { return this._forecastDataType; }
            set { this._forecastDataType = value; }
        }

        // Check to see if ForecastDataType property is set
        internal bool IsSetForecastDataType()
        {
            return this._forecastDataType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource. This string consists of the resource type and unique identifier.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Auto Scaling group - The resource type is <code>autoScalingGroup</code> and the unique
        /// identifier is the name of the Auto Scaling group. Example: <code>autoScalingGroup/my-asg</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ECS service - The resource type is <code>service</code> and the unique identifier
        /// is the cluster name and service name. Example: <code>service/default/sample-webapp</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Spot Fleet request - The resource type is <code>spot-fleet-request</code> and the
        /// unique identifier is the Spot Fleet request ID. Example: <code>spot-fleet-request/sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DynamoDB table - The resource type is <code>table</code> and the unique identifier
        /// is the resource ID. Example: <code>table/my-table</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DynamoDB global secondary index - The resource type is <code>index</code> and the
        /// unique identifier is the resource ID. Example: <code>table/my-table/index/my-table-index</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Aurora DB cluster - The resource type is <code>cluster</code> and the unique identifier
        /// is the cluster name. Example: <code>cluster:my-db-cluster</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ScalableDimension. 
        /// <para>
        /// The scalable dimension for the resource.
        /// </para>
        /// </summary>
        public ScalableDimension ScalableDimension
        {
            get { return this._scalableDimension; }
            set { this._scalableDimension = value; }
        }

        // Check to see if ScalableDimension property is set
        internal bool IsSetScalableDimension()
        {
            return this._scalableDimension != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingPlanName. 
        /// <para>
        /// The name of the scaling plan.
        /// </para>
        /// </summary>
        public string ScalingPlanName
        {
            get { return this._scalingPlanName; }
            set { this._scalingPlanName = value; }
        }

        // Check to see if ScalingPlanName property is set
        internal bool IsSetScalingPlanName()
        {
            return this._scalingPlanName != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingPlanVersion. 
        /// <para>
        /// The version number of the scaling plan.
        /// </para>
        /// </summary>
        public long ScalingPlanVersion
        {
            get { return this._scalingPlanVersion.GetValueOrDefault(); }
            set { this._scalingPlanVersion = value; }
        }

        // Check to see if ScalingPlanVersion property is set
        internal bool IsSetScalingPlanVersion()
        {
            return this._scalingPlanVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceNamespace. 
        /// <para>
        /// The namespace of the AWS service.
        /// </para>
        /// </summary>
        public ServiceNamespace ServiceNamespace
        {
            get { return this._serviceNamespace; }
            set { this._serviceNamespace = value; }
        }

        // Check to see if ServiceNamespace property is set
        internal bool IsSetServiceNamespace()
        {
            return this._serviceNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The inclusive start time of the time range for the forecast data to get. The date
        /// and time can be at most 56 days before the current date and time. 
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}