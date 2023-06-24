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
    /// The setup for the detailed tooltip.
    /// </summary>
    public partial class FieldBasedTooltip
    {
        private Visibility _aggregationVisibility;
        private List<TooltipItem> _tooltipFields = new List<TooltipItem>();
        private TooltipTitleType _tooltipTitleType;

        /// <summary>
        /// Gets and sets the property AggregationVisibility. 
        /// <para>
        /// The visibility of <code>Show aggregations</code>.
        /// </para>
        /// </summary>
        public Visibility AggregationVisibility
        {
            get { return this._aggregationVisibility; }
            set { this._aggregationVisibility = value; }
        }

        // Check to see if AggregationVisibility property is set
        internal bool IsSetAggregationVisibility()
        {
            return this._aggregationVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property TooltipFields. 
        /// <para>
        /// The fields configuration in the tooltip.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<TooltipItem> TooltipFields
        {
            get { return this._tooltipFields; }
            set { this._tooltipFields = value; }
        }

        // Check to see if TooltipFields property is set
        internal bool IsSetTooltipFields()
        {
            return this._tooltipFields != null && this._tooltipFields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TooltipTitleType. 
        /// <para>
        /// The type for the &gt;tooltip title. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NONE</code>: Doesn't use the primary value as the title.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PRIMARY_VALUE</code>: Uses primary value as the title.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TooltipTitleType TooltipTitleType
        {
            get { return this._tooltipTitleType; }
            set { this._tooltipTitleType = value; }
        }

        // Check to see if TooltipTitleType property is set
        internal bool IsSetTooltipTitleType()
        {
            return this._tooltipTitleType != null;
        }

    }
}