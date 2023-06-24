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
    /// The series axis configuration of a line chart.
    /// </summary>
    public partial class LineSeriesAxisDisplayOptions
    {
        private AxisDisplayOptions _axisOptions;
        private List<MissingDataConfiguration> _missingDataConfigurations = new List<MissingDataConfiguration>();

        /// <summary>
        /// Gets and sets the property AxisOptions. 
        /// <para>
        /// The options that determine the presentation of the line series axis.
        /// </para>
        /// </summary>
        public AxisDisplayOptions AxisOptions
        {
            get { return this._axisOptions; }
            set { this._axisOptions = value; }
        }

        // Check to see if AxisOptions property is set
        internal bool IsSetAxisOptions()
        {
            return this._axisOptions != null;
        }

        /// <summary>
        /// Gets and sets the property MissingDataConfigurations. 
        /// <para>
        /// The configuration options that determine how missing data is treated during the rendering
        /// of a line chart.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<MissingDataConfiguration> MissingDataConfigurations
        {
            get { return this._missingDataConfigurations; }
            set { this._missingDataConfigurations = value; }
        }

        // Check to see if MissingDataConfigurations property is set
        internal bool IsSetMissingDataConfigurations()
        {
            return this._missingDataConfigurations != null && this._missingDataConfigurations.Count > 0; 
        }

    }
}