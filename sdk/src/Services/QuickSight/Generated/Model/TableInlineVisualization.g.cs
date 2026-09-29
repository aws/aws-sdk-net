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
    /// The inline visualization of a specific type to display within a chart.
    /// </summary>
    public partial class TableInlineVisualization
    {
        /// <summary>
        /// Gets and sets the property DataBars. 
        /// <para>
        /// The configuration of the inline visualization of the data bars within a chart.
        /// </para>
        /// </summary>
        public DataBarsOptions DataBars { get; set; }

        /// <summary>
        /// Checks to see if the DataBars property is set.
        /// </summary>
        internal bool IsSetDataBars() => this.DataBars != null;

        /// <summary>
        /// Gets and sets the property Sparklines. 
        /// <para>
        /// The configuration of the inline visualization of the sparklines within a chart.
        /// </para>
        /// </summary>
        public SparklinesOptions Sparklines { get; set; }

        /// <summary>
        /// Checks to see if the Sparklines property is set.
        /// </summary>
        internal bool IsSetSparklines() => this.Sparklines != null;
    }
}
