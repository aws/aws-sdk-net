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

namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the GetPredictiveScalingForecast operation. Retrieves
    /// the forecast data for a predictive scaling policy. <para> Load forecasts are predictions
    /// of the hourly load values using historical load data from CloudWatch and an analysis
    /// of historical trends. Capacity forecasts are represented as predicted values for the
    /// minimum capacity that is needed on an hourly basis, based on the hourly load forecast.
    /// </para> <para> A minimum of 24 hours of data is required to create the initial forecasts.
    /// However, having a full 14 days of historical data results in more accurate forecasts.
    /// </para>
    /// </summary>
    public partial class GetPredictiveScalingForecastRequest : AmazonApplicationAutoScalingRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  The exclusive end time of the time range for the forecast data to get. The maximum
        /// time duration between the start and end time is 30 days. 
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
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        ///  The identifier of the resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ScalableDimension. 
        /// <para>
        ///  The scalable dimension. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScalableDimension ScalableDimension { get; set; }

        /// <summary>
        /// Checks to see if the ScalableDimension property is set.
        /// </summary>
        internal bool IsSetScalableDimension() => this.ScalableDimension != null;

        /// <summary>
        /// Gets and sets the property ServiceNamespace. 
        /// <para>
        ///  The namespace of the Amazon Web Services service that provides the resource. For
        /// a resource provided by your own application or service, use <c>custom-resource</c>
        /// instead. 
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
        ///  The inclusive start time of the time range for the forecast data to get. At most,
        /// the date and time can be one year before the current date and time 
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
