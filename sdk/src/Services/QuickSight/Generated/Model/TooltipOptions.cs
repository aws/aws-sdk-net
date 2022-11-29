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
    /// The display options for the visual tooltip.
    /// </summary>
    public partial class TooltipOptions
    {
        private FieldBasedTooltip _fieldBasedTooltip;
        private SelectedTooltipType _selectedTooltipType;
        private Visibility _tooltipVisibility;

        /// <summary>
        /// Gets and sets the property FieldBasedTooltip. 
        /// <para>
        /// The setup for the detailed tooltip. The tooltip setup is always saved. The display
        /// type is decided based on the tooltip type.
        /// </para>
        /// </summary>
        public FieldBasedTooltip FieldBasedTooltip
        {
            get { return this._fieldBasedTooltip; }
            set { this._fieldBasedTooltip = value; }
        }

        // Check to see if FieldBasedTooltip property is set
        internal bool IsSetFieldBasedTooltip()
        {
            return this._fieldBasedTooltip != null;
        }

        /// <summary>
        /// Gets and sets the property SelectedTooltipType. 
        /// <para>
        /// The selected type for the tooltip. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BASIC</code>: A basic tooltip.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DETAILED</code>: A detailed tooltip.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SelectedTooltipType SelectedTooltipType
        {
            get { return this._selectedTooltipType; }
            set { this._selectedTooltipType = value; }
        }

        // Check to see if SelectedTooltipType property is set
        internal bool IsSetSelectedTooltipType()
        {
            return this._selectedTooltipType != null;
        }

        /// <summary>
        /// Gets and sets the property TooltipVisibility. 
        /// <para>
        /// Determines whether or not the tooltip is visible.
        /// </para>
        /// </summary>
        public Visibility TooltipVisibility
        {
            get { return this._tooltipVisibility; }
            set { this._tooltipVisibility = value; }
        }

        // Check to see if TooltipVisibility property is set
        internal bool IsSetTooltipVisibility()
        {
            return this._tooltipVisibility != null;
        }

    }
}