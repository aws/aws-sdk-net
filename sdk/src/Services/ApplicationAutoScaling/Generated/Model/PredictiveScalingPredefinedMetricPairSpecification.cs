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
    /// Represents a metric pair for a predictive scaling policy. 
    /// 
    ///  
    /// <para>
    /// The following predefined metrics are available for predictive scaling:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>ECSServiceAverageCPUUtilization</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ECSServiceAverageMemoryUtilization</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ECSServiceCPUUtilization</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ECSServiceMemoryUtilization</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ECSServiceTotalCPUUtilization</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ECSServiceTotalMemoryUtilization</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ALBRequestCount</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ALBRequestCountPerTarget</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TotalALBRequestCount</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PredictiveScalingPredefinedMetricPairSpecification
    {
        private string _predefinedMetricType;
        private string _resourceLabel;

        /// <summary>
        /// Gets and sets the property PredefinedMetricType. 
        /// <para>
        ///  Indicates which metrics to use. There are two different types of metrics for each
        /// metric type: one is a load metric and one is a scaling metric. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string PredefinedMetricType
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
        /// Gets and sets the property ResourceLabel. 
        /// <para>
        ///  A label that uniquely identifies a specific target group from which to determine
        /// the total and average request count. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1023)]
        public string ResourceLabel
        {
            get { return this._resourceLabel; }
            set { this._resourceLabel = value; }
        }

        // Check to see if ResourceLabel property is set
        internal bool IsSetResourceLabel()
        {
            return this._resourceLabel != null;
        }

    }
}