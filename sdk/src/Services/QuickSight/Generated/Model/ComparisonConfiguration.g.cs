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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The comparison display configuration of a KPI or gauge chart.
    /// </summary>
    public partial class ComparisonConfiguration
    {
        /// <summary>
        /// Gets and sets the property ComparisonFormat. 
        /// <para>
        /// The format of the comparison.
        /// </para>
        /// </summary>
        public ComparisonFormatConfiguration ComparisonFormat { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonFormat property is set.
        /// </summary>
        internal bool IsSetComparisonFormat() => this.ComparisonFormat != null;

        /// <summary>
        /// Gets and sets the property ComparisonMethod. 
        /// <para>
        /// The method of the comparison. Choose from the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DIFFERENCE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PERCENT_DIFFERENCE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PERCENT</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ComparisonMethod ComparisonMethod { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonMethod property is set.
        /// </summary>
        internal bool IsSetComparisonMethod() => this.ComparisonMethod != null;
    }
}
