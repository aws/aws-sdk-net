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
    /// The options that determine the presentation of a waterfall visual.
    /// </summary>
    public partial class WaterfallChartOptions
    {
        private string _totalBarLabel;

        /// <summary>
        /// Gets and sets the property TotalBarLabel. 
        /// <para>
        /// This option determines the total bar label of a waterfall visual.
        /// </para>
        /// </summary>
        public string TotalBarLabel
        {
            get { return this._totalBarLabel; }
            set { this._totalBarLabel = value; }
        }

        // Check to see if TotalBarLabel property is set
        internal bool IsSetTotalBarLabel()
        {
            return this._totalBarLabel != null;
        }

    }
}