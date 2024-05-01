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
    /// Describes a metric.
    /// </summary>
    public partial class MetricCollectionType
    {
        private string _metric;

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// One of the following metrics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>GroupMinSize</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupMaxSize</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupDesiredCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupInServiceInstances</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupPendingInstances</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupStandbyInstances</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupTerminatingInstances</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupTotalInstances</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupInServiceCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupPendingCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupStandbyCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupTerminatingCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupTotalCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WarmPoolDesiredCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WarmPoolWarmedCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WarmPoolPendingCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WarmPoolTerminatingCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WarmPoolTotalCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupAndWarmPoolDesiredCapacity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GroupAndWarmPoolTotalCapacity</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Metric
        {
            get { return this._metric; }
            set { this._metric = value; }
        }

        // Check to see if Metric property is set
        internal bool IsSetMetric()
        {
            return this._metric != null;
        }

    }
}