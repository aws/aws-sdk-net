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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
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
namespace Amazon.Shield.Model
{
    /// <summary>
    /// The counter that describes a DDoS attack.
    /// </summary>
    public partial class SummarizedCounter
    {
        private double? _average;
        private double? _max;
        private int? _n;
        private string _name;
        private double? _sum;
        private string _unit;

        /// <summary>
        /// Gets and sets the property Average. 
        /// <para>
        /// The average value of the counter for a specified time period.
        /// </para>
        /// </summary>
        public double? Average
        {
            get { return this._average; }
            set { this._average = value; }
        }

        // Check to see if Average property is set
        internal bool IsSetAverage()
        {
            return this._average.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// The maximum value of the counter for a specified time period.
        /// </para>
        /// </summary>
        public double? Max
        {
            get { return this._max; }
            set { this._max = value; }
        }

        // Check to see if Max property is set
        internal bool IsSetMax()
        {
            return this._max.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property N. 
        /// <para>
        /// The number of counters for a specified time period.
        /// </para>
        /// </summary>
        public int? N
        {
            get { return this._n; }
            set { this._n = value; }
        }

        // Check to see if N property is set
        internal bool IsSetN()
        {
            return this._n.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The counter name.
        /// </para>
        /// </summary>
        public string Name
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
        /// Gets and sets the property Sum. 
        /// <para>
        /// The total of counter values for a specified time period.
        /// </para>
        /// </summary>
        public double? Sum
        {
            get { return this._sum; }
            set { this._sum = value; }
        }

        // Check to see if Sum property is set
        internal bool IsSetSum()
        {
            return this._sum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of the counters.
        /// </para>
        /// </summary>
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}