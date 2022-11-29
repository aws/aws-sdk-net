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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The comparison display configuration of a KPI or gauge chart.
    /// </summary>
    public partial class ComparisonConfiguration
    {
        private ComparisonFormatConfiguration _comparisonFormat;
        private ComparisonMethod _comparisonMethod;

        /// <summary>
        /// Gets and sets the property ComparisonFormat. 
        /// <para>
        /// The format of the comparison.
        /// </para>
        /// </summary>
        public ComparisonFormatConfiguration ComparisonFormat
        {
            get { return this._comparisonFormat; }
            set { this._comparisonFormat = value; }
        }

        // Check to see if ComparisonFormat property is set
        internal bool IsSetComparisonFormat()
        {
            return this._comparisonFormat != null;
        }

        /// <summary>
        /// Gets and sets the property ComparisonMethod. 
        /// <para>
        /// The method of the comparison. Choose from the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DIFFERENCE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PERCENT_DIFFERENCE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PERCENT</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ComparisonMethod ComparisonMethod
        {
            get { return this._comparisonMethod; }
            set { this._comparisonMethod = value; }
        }

        // Check to see if ComparisonMethod property is set
        internal bool IsSetComparisonMethod()
        {
            return this._comparisonMethod != null;
        }

    }
}