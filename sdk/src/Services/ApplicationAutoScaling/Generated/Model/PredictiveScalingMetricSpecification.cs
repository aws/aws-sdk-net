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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
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
    /// This structure specifies the metrics and target utilization settings for a predictive
    /// scaling policy. 
    /// 
    ///  
    /// <para>
    /// You must specify either a metric pair, or a load metric and a scaling metric individually.
    /// Specifying a metric pair instead of individual metrics provides a simpler way to configure
    /// metrics for a scaling policy. You choose the metric pair, and the policy automatically
    /// knows the correct sum and average statistics to use for the load metric and the scaling
    /// metric.
    /// </para>
    /// </summary>
    public partial class PredictiveScalingMetricSpecification
    {
        private PredictiveScalingCustomizedMetricSpecification _customizedCapacityMetricSpecification;
        private PredictiveScalingCustomizedMetricSpecification _customizedLoadMetricSpecification;
        private PredictiveScalingCustomizedMetricSpecification _customizedScalingMetricSpecification;
        private PredictiveScalingPredefinedLoadMetricSpecification _predefinedLoadMetricSpecification;
        private PredictiveScalingPredefinedMetricPairSpecification _predefinedMetricPairSpecification;
        private PredictiveScalingPredefinedScalingMetricSpecification _predefinedScalingMetricSpecification;
        private double? _targetValue;

        /// <summary>
        /// Gets and sets the property CustomizedCapacityMetricSpecification. 
        /// <para>
        ///  The customized capacity metric specification. 
        /// </para>
        /// </summary>
        public PredictiveScalingCustomizedMetricSpecification CustomizedCapacityMetricSpecification
        {
            get { return this._customizedCapacityMetricSpecification; }
            set { this._customizedCapacityMetricSpecification = value; }
        }

        // Check to see if CustomizedCapacityMetricSpecification property is set
        internal bool IsSetCustomizedCapacityMetricSpecification()
        {
            return this._customizedCapacityMetricSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property CustomizedLoadMetricSpecification. 
        /// <para>
        ///  The customized load metric specification. 
        /// </para>
        /// </summary>
        public PredictiveScalingCustomizedMetricSpecification CustomizedLoadMetricSpecification
        {
            get { return this._customizedLoadMetricSpecification; }
            set { this._customizedLoadMetricSpecification = value; }
        }

        // Check to see if CustomizedLoadMetricSpecification property is set
        internal bool IsSetCustomizedLoadMetricSpecification()
        {
            return this._customizedLoadMetricSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property CustomizedScalingMetricSpecification. 
        /// <para>
        ///  The customized scaling metric specification. 
        /// </para>
        /// </summary>
        public PredictiveScalingCustomizedMetricSpecification CustomizedScalingMetricSpecification
        {
            get { return this._customizedScalingMetricSpecification; }
            set { this._customizedScalingMetricSpecification = value; }
        }

        // Check to see if CustomizedScalingMetricSpecification property is set
        internal bool IsSetCustomizedScalingMetricSpecification()
        {
            return this._customizedScalingMetricSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property PredefinedLoadMetricSpecification. 
        /// <para>
        ///  The predefined load metric specification. 
        /// </para>
        /// </summary>
        public PredictiveScalingPredefinedLoadMetricSpecification PredefinedLoadMetricSpecification
        {
            get { return this._predefinedLoadMetricSpecification; }
            set { this._predefinedLoadMetricSpecification = value; }
        }

        // Check to see if PredefinedLoadMetricSpecification property is set
        internal bool IsSetPredefinedLoadMetricSpecification()
        {
            return this._predefinedLoadMetricSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property PredefinedMetricPairSpecification. 
        /// <para>
        ///  The predefined metric pair specification that determines the appropriate scaling
        /// metric and load metric to use. 
        /// </para>
        /// </summary>
        public PredictiveScalingPredefinedMetricPairSpecification PredefinedMetricPairSpecification
        {
            get { return this._predefinedMetricPairSpecification; }
            set { this._predefinedMetricPairSpecification = value; }
        }

        // Check to see if PredefinedMetricPairSpecification property is set
        internal bool IsSetPredefinedMetricPairSpecification()
        {
            return this._predefinedMetricPairSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property PredefinedScalingMetricSpecification. 
        /// <para>
        ///  The predefined scaling metric specification. 
        /// </para>
        /// </summary>
        public PredictiveScalingPredefinedScalingMetricSpecification PredefinedScalingMetricSpecification
        {
            get { return this._predefinedScalingMetricSpecification; }
            set { this._predefinedScalingMetricSpecification = value; }
        }

        // Check to see if PredefinedScalingMetricSpecification property is set
        internal bool IsSetPredefinedScalingMetricSpecification()
        {
            return this._predefinedScalingMetricSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property TargetValue. 
        /// <para>
        ///  Specifies the target utilization. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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