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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
    /// Represents a target tracking scaling policy configuration to use with Amazon EC2 Auto
    /// Scaling.
    /// </summary>
    public partial class TargetTrackingConfiguration
    {
        private CustomizedMetricSpecification _customizedMetricSpecification;
        private bool? _disableScaleIn;
        private PredefinedMetricSpecification _predefinedMetricSpecification;
        private double? _targetValue;

        /// <summary>
        /// Gets and sets the property CustomizedMetricSpecification. 
        /// <para>
        /// A customized metric. You must specify either a predefined metric or a customized metric.
        /// </para>
        /// </summary>
        public CustomizedMetricSpecification CustomizedMetricSpecification
        {
            get { return this._customizedMetricSpecification; }
            set { this._customizedMetricSpecification = value; }
        }

        // Check to see if CustomizedMetricSpecification property is set
        internal bool IsSetCustomizedMetricSpecification()
        {
            return this._customizedMetricSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property DisableScaleIn. 
        /// <para>
        /// Indicates whether scaling in by the target tracking scaling policy is disabled. If
        /// scaling in is disabled, the target tracking scaling policy doesn't remove instances
        /// from the Auto Scaling group. Otherwise, the target tracking scaling policy can remove
        /// instances from the Auto Scaling group. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? DisableScaleIn
        {
            get { return this._disableScaleIn; }
            set { this._disableScaleIn = value; }
        }

        // Check to see if DisableScaleIn property is set
        internal bool IsSetDisableScaleIn()
        {
            return this._disableScaleIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PredefinedMetricSpecification. 
        /// <para>
        /// A predefined metric. You must specify either a predefined metric or a customized metric.
        /// </para>
        /// </summary>
        public PredefinedMetricSpecification PredefinedMetricSpecification
        {
            get { return this._predefinedMetricSpecification; }
            set { this._predefinedMetricSpecification = value; }
        }

        // Check to see if PredefinedMetricSpecification property is set
        internal bool IsSetPredefinedMetricSpecification()
        {
            return this._predefinedMetricSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property TargetValue. 
        /// <para>
        /// The target value for the metric.
        /// </para>
        ///  <note> 
        /// <para>
        /// Some metrics are based on a count instead of a percentage, such as the request count
        /// for an Application Load Balancer or the number of messages in an SQS queue. If the
        /// scaling policy specifies one of these metrics, specify the target utilization as the
        /// optimal average request or message count per instance during any one-minute interval.
        /// 
        /// </para>
        ///  </note>
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