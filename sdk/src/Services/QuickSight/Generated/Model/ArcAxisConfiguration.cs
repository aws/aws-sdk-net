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
    /// The arc axis configuration of a <code>GaugeChartVisual</code>.
    /// </summary>
    public partial class ArcAxisConfiguration
    {
        private ArcAxisDisplayRange _range;
        private int? _reserveRange;

        /// <summary>
        /// Gets and sets the property Range. 
        /// <para>
        /// The arc axis range of a <code>GaugeChartVisual</code>.
        /// </para>
        /// </summary>
        public ArcAxisDisplayRange Range
        {
            get { return this._range; }
            set { this._range = value; }
        }

        // Check to see if Range property is set
        internal bool IsSetRange()
        {
            return this._range != null;
        }

        /// <summary>
        /// Gets and sets the property ReserveRange. 
        /// <para>
        /// The reserved range of the arc axis.
        /// </para>
        /// </summary>
        public int ReserveRange
        {
            get { return this._reserveRange.GetValueOrDefault(); }
            set { this._reserveRange = value; }
        }

        // Check to see if ReserveRange property is set
        internal bool IsSetReserveRange()
        {
            return this._reserveRange.HasValue; 
        }

    }
}