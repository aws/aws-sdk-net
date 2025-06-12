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
    /// The setup for the detailed tooltip.
    /// </summary>
    public partial class FieldBasedTooltip
    {
        private Visibility _aggregationVisibility;
        private List<TooltipItem> _tooltipFields = AWSConfigs.InitializeCollections ? new List<TooltipItem>() : null;
        private TooltipTitleType _tooltipTitleType;

        /// <summary>
        /// Gets and sets the property AggregationVisibility. 
        /// <para>
        /// The visibility of <c>Show aggregations</c>.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tooltipFields != null && (this._tooltipFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TooltipTitleType. 
        /// <para>
        /// The type for the &gt;tooltip title. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c>: Doesn't use the primary value as the title.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PRIMARY_VALUE</c>: Uses primary value as the title.
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