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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A target tracking scaling policy. Includes support for predefined or customized metrics.
    /// 
    ///  
    /// <para>
    /// When using the <a href="https://docs.aws.amazon.com/autoscaling/application/APIReference/API_PutScalingPolicy.html">PutScalingPolicy</a>
    /// API, this parameter is required when you are creating a policy with the policy type
    /// <c>TargetTrackingScaling</c>.
    /// </para>
    /// </summary>
    public partial class TargetTrackingScalingPolicyConfiguration
    {
        private MetricSpecification _metricSpecification;
        private double? _targetValue;

        /// <summary>
        /// Gets and sets the property MetricSpecification. 
        /// <para>
        /// An object containing information about a metric.
        /// </para>
        /// </summary>
        public MetricSpecification MetricSpecification
        {
            get { return this._metricSpecification; }
            set { this._metricSpecification = value; }
        }

        // Check to see if MetricSpecification property is set
        internal bool IsSetMetricSpecification()
        {
            return this._metricSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property TargetValue. 
        /// <para>
        /// The recommended target value to specify for the metric when creating a scaling policy.
        /// </para>
        /// </summary>
        public double? TargetValue
        {
            get { return this._targetValue; }
            set { this._targetValue = value; }
        }

        // Check to see if TargetValue property is set
        internal bool IsSetTargetValue()
        {
            return this._targetValue.HasValue; 
        }

    }
}