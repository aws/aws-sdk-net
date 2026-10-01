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
    /// The configuration that determines what the type of layout will be used on a sheet.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class LayoutConfiguration
    {
        /// <summary>
        /// Gets and sets the property FreeFormLayout. 
        /// <para>
        /// A free-form is optimized for a fixed width and has more control over the exact placement
        /// of layout elements.
        /// </para>
        /// </summary>
        public FreeFormLayoutConfiguration FreeFormLayout { get; set; }

        /// <summary>
        /// Checks to see if the FreeFormLayout property is set.
        /// </summary>
        internal bool IsSetFreeFormLayout() => this.FreeFormLayout != null;

        /// <summary>
        /// Gets and sets the property GridLayout. 
        /// <para>
        /// A type of layout that can be used on a sheet. In a grid layout, visuals snap to a
        /// grid with standard spacing and alignment. Dashboards are displayed as designed, with
        /// options to fit to screen or view at actual size. A grid layout can be configured to
        /// behave in one of two ways when the viewport is resized: <c>FIXED</c> or <c>RESPONSIVE</c>.
        /// </para>
        /// </summary>
        public GridLayoutConfiguration GridLayout { get; set; }

        /// <summary>
        /// Checks to see if the GridLayout property is set.
        /// </summary>
        internal bool IsSetGridLayout() => this.GridLayout != null;

        /// <summary>
        /// Gets and sets the property SectionBasedLayout. 
        /// <para>
        /// A section based layout organizes visuals into multiple sections and has customized
        /// header, footer and page break.
        /// </para>
        /// </summary>
        public SectionBasedLayoutConfiguration SectionBasedLayout { get; set; }

        /// <summary>
        /// Checks to see if the SectionBasedLayout property is set.
        /// </summary>
        internal bool IsSetSectionBasedLayout() => this.SectionBasedLayout != null;
    }
}
