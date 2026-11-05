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

namespace Amazon.Shield.Model
{
    /// <summary>
    /// The counter that describes a DDoS attack.
    /// </summary>
    public partial class SummarizedCounter
    {
        /// <summary>
        /// Gets and sets the property Average. 
        /// <para>
        /// The average value of the counter for a specified time period.
        /// </para>
        /// </summary>
        public double? Average { get; set; }

        /// <summary>
        /// Checks to see if the Average property is set.
        /// </summary>
        internal bool IsSetAverage() => this.Average.HasValue;

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// The maximum value of the counter for a specified time period.
        /// </para>
        /// </summary>
        public double? Max { get; set; }

        /// <summary>
        /// Checks to see if the Max property is set.
        /// </summary>
        internal bool IsSetMax() => this.Max.HasValue;

        /// <summary>
        /// Gets and sets the property N. 
        /// <para>
        /// The number of counters for a specified time period.
        /// </para>
        /// </summary>
        public int? N { get; set; }

        /// <summary>
        /// Checks to see if the N property is set.
        /// </summary>
        internal bool IsSetN() => this.N.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The counter name.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Sum. 
        /// <para>
        /// The total of counter values for a specified time period.
        /// </para>
        /// </summary>
        public double? Sum { get; set; }

        /// <summary>
        /// Checks to see if the Sum property is set.
        /// </summary>
        internal bool IsSetSum() => this.Sum.HasValue;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of the counters.
        /// </para>
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;
    }
}
