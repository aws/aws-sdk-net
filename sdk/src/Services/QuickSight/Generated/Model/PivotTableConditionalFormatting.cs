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
    /// The conditional formatting for a <code>PivotTableVisual</code>.
    /// </summary>
    public partial class PivotTableConditionalFormatting
    {
        private List<PivotTableConditionalFormattingOption> _conditionalFormattingOptions = new List<PivotTableConditionalFormattingOption>();

        /// <summary>
        /// Gets and sets the property ConditionalFormattingOptions. 
        /// <para>
        /// Conditional formatting options for a <code>PivotTableVisual</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<PivotTableConditionalFormattingOption> ConditionalFormattingOptions
        {
            get { return this._conditionalFormattingOptions; }
            set { this._conditionalFormattingOptions = value; }
        }

        // Check to see if ConditionalFormattingOptions property is set
        internal bool IsSetConditionalFormattingOptions()
        {
            return this._conditionalFormattingOptions != null && this._conditionalFormattingOptions.Count > 0; 
        }

    }
}