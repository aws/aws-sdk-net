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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// A scaling policy for the capacity provider that automatically adjusts capacity to
    /// maintain a target value for a specific metric.
    /// </summary>
    public partial class TargetTrackingScalingPolicy
    {
        private CapacityProviderPredefinedMetricType _predefinedMetricType;
        private double? _targetValue;

        /// <summary>
        /// Gets and sets the property PredefinedMetricType. 
        /// <para>
        /// The predefined metric type to track for scaling decisions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CapacityProviderPredefinedMetricType PredefinedMetricType
        {
            get { return this._predefinedMetricType; }
            set { this._predefinedMetricType = value; }
        }

        // Check to see if PredefinedMetricType property is set
        internal bool IsSetPredefinedMetricType()
        {
            return this._predefinedMetricType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetValue. 
        /// <para>
        /// The target value for the metric that the scaling policy attempts to maintain through
        /// scaling actions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
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