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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes the projected metrics of an Amazon ECS service recommendation option. 
    /// 
    ///  
    /// <para>
    /// To determine the performance difference between your current Amazon ECS service and
    /// the recommended option, compare the metric data of your service against its projected
    /// metric data.
    /// </para>
    /// </summary>
    public partial class ECSServiceProjectedMetric
    {
        private List<double> _lowerBoundValues = new List<double>();
        private ECSServiceMetricName _name;
        private List<DateTime> _timestamps = new List<DateTime>();
        private List<double> _upperBoundValues = new List<double>();

        /// <summary>
        /// Gets and sets the property LowerBoundValues. 
        /// <para>
        ///  The lower bound values for the projected metric. 
        /// </para>
        /// </summary>
        public List<double> LowerBoundValues
        {
            get { return this._lowerBoundValues; }
            set { this._lowerBoundValues = value; }
        }

        // Check to see if LowerBoundValues property is set
        internal bool IsSetLowerBoundValues()
        {
            return this._lowerBoundValues != null && this._lowerBoundValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the projected metric. 
        /// </para>
        ///  
        /// <para>
        /// The following metrics are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Cpu</code> — The percentage of allocated compute units that are currently in
        /// use on the service tasks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Memory</code> — The percentage of memory that's currently in use on the service
        /// tasks.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ECSServiceMetricName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamps. 
        /// <para>
        ///  The timestamps of the projected metric. 
        /// </para>
        /// </summary>
        public List<DateTime> Timestamps
        {
            get { return this._timestamps; }
            set { this._timestamps = value; }
        }

        // Check to see if Timestamps property is set
        internal bool IsSetTimestamps()
        {
            return this._timestamps != null && this._timestamps.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpperBoundValues. 
        /// <para>
        ///  The upper bound values for the projected metric. 
        /// </para>
        /// </summary>
        public List<double> UpperBoundValues
        {
            get { return this._upperBoundValues; }
            set { this._upperBoundValues = value; }
        }

        // Check to see if UpperBoundValues property is set
        internal bool IsSetUpperBoundValues()
        {
            return this._upperBoundValues != null && this._upperBoundValues.Count > 0; 
        }

    }
}