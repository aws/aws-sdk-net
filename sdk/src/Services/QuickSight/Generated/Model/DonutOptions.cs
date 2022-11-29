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
    /// The options for configuring a donut chart or pie chart.
    /// </summary>
    public partial class DonutOptions
    {
        private ArcOptions _arcOptions;
        private DonutCenterOptions _donutCenterOptions;

        /// <summary>
        /// Gets and sets the property ArcOptions. 
        /// <para>
        /// The option for define the arc of the chart shape. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>WHOLE</code> - A pie chart
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SMALL</code>- A small-sized donut chart
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MEDIUM</code>- A medium-sized donut chart
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LARGE</code>- A large-sized donut chart
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ArcOptions ArcOptions
        {
            get { return this._arcOptions; }
            set { this._arcOptions = value; }
        }

        // Check to see if ArcOptions property is set
        internal bool IsSetArcOptions()
        {
            return this._arcOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DonutCenterOptions. 
        /// <para>
        /// The label options of the label that is displayed in the center of a donut chart. This
        /// option isn't available for pie charts.
        /// </para>
        /// </summary>
        public DonutCenterOptions DonutCenterOptions
        {
            get { return this._donutCenterOptions; }
            set { this._donutCenterOptions = value; }
        }

        // Check to see if DonutCenterOptions property is set
        internal bool IsSetDonutCenterOptions()
        {
            return this._donutCenterOptions != null;
        }

    }
}