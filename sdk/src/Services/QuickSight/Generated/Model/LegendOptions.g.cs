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
    /// The options for the legend setup of a visual.
    /// </summary>
    public partial class LegendOptions
    {
        /// <summary>
        /// Gets and sets the property Height. 
        /// <para>
        /// The height of the legend. If this value is omitted, a default height is used when
        /// rendering.
        /// </para>
        /// </summary>
        public string Height { get; set; }

        /// <summary>
        /// Checks to see if the Height property is set.
        /// </summary>
        internal bool IsSetHeight() => this.Height != null;

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The positions for the legend. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AUTO</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RIGHT</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BOTTOM</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LEFT</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LegendPosition Position { get; set; }

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The custom title for the legend.
        /// </para>
        /// </summary>
        public LabelOptions Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property ValueFontConfiguration.
        /// </summary>
        public FontConfiguration ValueFontConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ValueFontConfiguration property is set.
        /// </summary>
        internal bool IsSetValueFontConfiguration() => this.ValueFontConfiguration != null;

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// Determines whether or not the legend is visible.
        /// </para>
        /// </summary>
        public Visibility Visibility { get; set; }

        /// <summary>
        /// Checks to see if the Visibility property is set.
        /// </summary>
        internal bool IsSetVisibility() => this.Visibility != null;

        /// <summary>
        /// Gets and sets the property Width. 
        /// <para>
        /// The width of the legend. If this value is omitted, a default width is used when rendering.
        /// </para>
        /// </summary>
        public string Width { get; set; }

        /// <summary>
        /// Checks to see if the Width property is set.
        /// </summary>
        internal bool IsSetWidth() => this.Width != null;
    }
}
