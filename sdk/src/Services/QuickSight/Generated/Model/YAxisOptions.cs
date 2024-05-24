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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The options that are available for a single Y axis in a chart.
    /// </summary>
    public partial class YAxisOptions
    {
        private SingleYAxisOption _yAxis;

        /// <summary>
        /// Gets and sets the property YAxis. 
        /// <para>
        /// The Y axis type to be used in the chart.
        /// </para>
        ///  
        /// <para>
        /// If you choose <c>PRIMARY_Y_AXIS</c>, the primary Y Axis is located on the leftmost
        /// vertical axis of the chart.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SingleYAxisOption YAxis
        {
            get { return this._yAxis; }
            set { this._yAxis = value; }
        }

        // Check to see if YAxis property is set
        internal bool IsSetYAxis()
        {
            return this._yAxis != null;
        }

    }
}