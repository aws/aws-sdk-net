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
        /// <summary>
        /// Gets and sets the property CustomizedCapacityMetricSpecification. 
        /// <para>
        ///  The customized capacity metric specification. 
        /// </para>
        /// </summary>
        public PredictiveScalingCustomizedMetricSpecification CustomizedCapacityMetricSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CustomizedCapacityMetricSpecification property is set.
        /// </summary>
        internal bool IsSetCustomizedCapacityMetricSpecification() => this.CustomizedCapacityMetricSpecification != null;

        /// <summary>
        /// Gets and sets the property CustomizedLoadMetricSpecification. 
        /// <para>
        ///  The customized load metric specification. 
        /// </para>
        /// </summary>
        public PredictiveScalingCustomizedMetricSpecification CustomizedLoadMetricSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CustomizedLoadMetricSpecification property is set.
        /// </summary>
        internal bool IsSetCustomizedLoadMetricSpecification() => this.CustomizedLoadMetricSpecification != null;

        /// <summary>
        /// Gets and sets the property CustomizedScalingMetricSpecification. 
        /// <para>
        ///  The customized scaling metric specification. 
        /// </para>
        /// </summary>
        public PredictiveScalingCustomizedMetricSpecification CustomizedScalingMetricSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CustomizedScalingMetricSpecification property is set.
        /// </summary>
        internal bool IsSetCustomizedScalingMetricSpecification() => this.CustomizedScalingMetricSpecification != null;

        /// <summary>
        /// Gets and sets the property PredefinedLoadMetricSpecification. 
        /// <para>
        ///  The predefined load metric specification. 
        /// </para>
        /// </summary>
        public PredictiveScalingPredefinedLoadMetricSpecification PredefinedLoadMetricSpecification { get; set; }

        /// <summary>
        /// Checks to see if the PredefinedLoadMetricSpecification property is set.
        /// </summary>
        internal bool IsSetPredefinedLoadMetricSpecification() => this.PredefinedLoadMetricSpecification != null;

        /// <summary>
        /// Gets and sets the property PredefinedMetricPairSpecification. 
        /// <para>
        ///  The predefined metric pair specification that determines the appropriate scaling
        /// metric and load metric to use. 
        /// </para>
        /// </summary>
        public PredictiveScalingPredefinedMetricPairSpecification PredefinedMetricPairSpecification { get; set; }

        /// <summary>
        /// Checks to see if the PredefinedMetricPairSpecification property is set.
        /// </summary>
        internal bool IsSetPredefinedMetricPairSpecification() => this.PredefinedMetricPairSpecification != null;

        /// <summary>
        /// Gets and sets the property PredefinedScalingMetricSpecification. 
        /// <para>
        ///  The predefined scaling metric specification. 
        /// </para>
        /// </summary>
        public PredictiveScalingPredefinedScalingMetricSpecification PredefinedScalingMetricSpecification { get; set; }

        /// <summary>
        /// Checks to see if the PredefinedScalingMetricSpecification property is set.
        /// </summary>
        internal bool IsSetPredefinedScalingMetricSpecification() => this.PredefinedScalingMetricSpecification != null;

        /// <summary>
        /// Gets and sets the property TargetValue. 
        /// <para>
        ///  Specifies the target utilization. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? TargetValue { get; set; }

        /// <summary>
        /// Checks to see if the TargetValue property is set.
        /// </summary>
        internal bool IsSetTargetValue() => this.TargetValue.HasValue;
    }
}
