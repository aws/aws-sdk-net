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
    /// The display options for the visual tooltip.
    /// </summary>
    public partial class TooltipOptions
    {
        /// <summary>
        /// Gets and sets the property FieldBasedTooltip. 
        /// <para>
        /// The setup for the detailed tooltip. The tooltip setup is always saved. The display
        /// type is decided based on the tooltip type.
        /// </para>
        /// </summary>
        public FieldBasedTooltip FieldBasedTooltip { get; set; }

        /// <summary>
        /// Checks to see if the FieldBasedTooltip property is set.
        /// </summary>
        internal bool IsSetFieldBasedTooltip() => this.FieldBasedTooltip != null;

        /// <summary>
        /// Gets and sets the property SelectedTooltipType. 
        /// <para>
        /// The selected type for the tooltip. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BASIC</c>: A basic tooltip.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DETAILED</c>: A detailed tooltip.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SelectedTooltipType SelectedTooltipType { get; set; }

        /// <summary>
        /// Checks to see if the SelectedTooltipType property is set.
        /// </summary>
        internal bool IsSetSelectedTooltipType() => this.SelectedTooltipType != null;

        /// <summary>
        /// Gets and sets the property SheetTooltip.
        /// </summary>
        public SheetTooltip SheetTooltip { get; set; }

        /// <summary>
        /// Checks to see if the SheetTooltip property is set.
        /// </summary>
        internal bool IsSetSheetTooltip() => this.SheetTooltip != null;

        /// <summary>
        /// Gets and sets the property TooltipVisibility. 
        /// <para>
        /// Determines whether or not the tooltip is visible.
        /// </para>
        /// </summary>
        public Visibility TooltipVisibility { get; set; }

        /// <summary>
        /// Checks to see if the TooltipVisibility property is set.
        /// </summary>
        internal bool IsSetTooltipVisibility() => this.TooltipVisibility != null;
    }
}
