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
    /// The label configuration of a reference line.
    /// </summary>
    public partial class ReferenceLineLabelConfiguration
    {
        /// <summary>
        /// Gets and sets the property CustomLabelConfiguration. 
        /// <para>
        /// The custom label configuration of the label in a reference line.
        /// </para>
        /// </summary>
        public ReferenceLineCustomLabelConfiguration CustomLabelConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CustomLabelConfiguration property is set.
        /// </summary>
        internal bool IsSetCustomLabelConfiguration() => this.CustomLabelConfiguration != null;

        /// <summary>
        /// Gets and sets the property FontColor. 
        /// <para>
        /// The font color configuration of the label in a reference line.
        /// </para>
        /// </summary>
        public string FontColor { get; set; }

        /// <summary>
        /// Checks to see if the FontColor property is set.
        /// </summary>
        internal bool IsSetFontColor() => this.FontColor != null;

        /// <summary>
        /// Gets and sets the property FontConfiguration. 
        /// <para>
        /// The font configuration of the label in a reference line.
        /// </para>
        /// </summary>
        public FontConfiguration FontConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FontConfiguration property is set.
        /// </summary>
        internal bool IsSetFontConfiguration() => this.FontConfiguration != null;

        /// <summary>
        /// Gets and sets the property HorizontalPosition. 
        /// <para>
        /// The horizontal position configuration of the label in a reference line. Choose one
        /// of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LEFT</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CENTER</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RIGHT</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReferenceLineLabelHorizontalPosition HorizontalPosition { get; set; }

        /// <summary>
        /// Checks to see if the HorizontalPosition property is set.
        /// </summary>
        internal bool IsSetHorizontalPosition() => this.HorizontalPosition != null;

        /// <summary>
        /// Gets and sets the property ValueLabelConfiguration. 
        /// <para>
        /// The value label configuration of the label in a reference line.
        /// </para>
        /// </summary>
        public ReferenceLineValueLabelConfiguration ValueLabelConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ValueLabelConfiguration property is set.
        /// </summary>
        internal bool IsSetValueLabelConfiguration() => this.ValueLabelConfiguration != null;

        /// <summary>
        /// Gets and sets the property VerticalPosition. 
        /// <para>
        /// The vertical position configuration of the label in a reference line. Choose one of
        /// the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ABOVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BELOW</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReferenceLineLabelVerticalPosition VerticalPosition { get; set; }

        /// <summary>
        /// Checks to see if the VerticalPosition property is set.
        /// </summary>
        internal bool IsSetVerticalPosition() => this.VerticalPosition != null;
    }
}
