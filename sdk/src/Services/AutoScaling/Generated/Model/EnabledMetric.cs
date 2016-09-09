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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes an enabled metric.
    /// </summary>
    public partial class EnabledMetric
    {
        private string _granularity;
        private string _metric;

        /// <summary>
        /// Gets and sets the property Granularity. 
        /// <para>
        /// The granularity of the metric. The only valid value is <code>1Minute</code>.
        /// </para>
        /// </summary>
        public string Granularity
        {
            get { return this._granularity; }
            set { this._granularity = value; }
        }

        // Check to see if Granularity property is set
        internal bool IsSetGranularity()
        {
            return this._granularity != null;
        }

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// One of the following metrics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>GroupMinSize</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupMaxSize</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupDesiredCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupInServiceInstances</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupPendingInstances</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupStandbyInstances</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupTerminatingInstances</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupTotalInstances</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
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