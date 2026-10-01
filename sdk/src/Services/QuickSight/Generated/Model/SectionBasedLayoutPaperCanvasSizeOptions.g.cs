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
    /// The options for a paper canvas of a section-based layout.
    /// </summary>
    public partial class SectionBasedLayoutPaperCanvasSizeOptions
    {
        /// <summary>
        /// Gets and sets the property PaperMargin. 
        /// <para>
        /// Defines the spacing between the canvas content and the top, bottom, left, and right
        /// edges.
        /// </para>
        /// </summary>
        public Spacing PaperMargin { get; set; }

        /// <summary>
        /// Checks to see if the PaperMargin property is set.
        /// </summary>
        internal bool IsSetPaperMargin() => this.PaperMargin != null;

        /// <summary>
        /// Gets and sets the property PaperOrientation. 
        /// <para>
        /// The paper orientation that is used to define canvas dimensions. Choose one of the
        /// following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PORTRAIT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LANDSCAPE
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PaperOrientation PaperOrientation { get; set; }

        /// <summary>
        /// Checks to see if the PaperOrientation property is set.
        /// </summary>
        internal bool IsSetPaperOrientation() => this.PaperOrientation != null;

        /// <summary>
        /// Gets and sets the property PaperSize. 
        /// <para>
        /// The paper size that is used to define canvas dimensions.
        /// </para>
        /// </summary>
        public PaperSize PaperSize { get; set; }

        /// <summary>
        /// Checks to see if the PaperSize property is set.
        /// </summary>
        internal bool IsSetPaperSize() => this.PaperSize != null;
    }
}
