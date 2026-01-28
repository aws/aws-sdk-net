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
    /// Decal settings for accessibility features that define visual patterns and styling
    /// for data elements.
    /// </summary>
    public partial class DecalSettings
    {
        private string _decalColor;
        private DecalPatternType _decalPatternType;
        private DecalStyleType _decalStyleType;
        private Visibility _decalVisibility;
        private string _elementValue;

        /// <summary>
        /// Gets and sets the property DecalColor. 
        /// <para>
        /// Color configuration for the decal pattern.
        /// </para>
        /// </summary>
        public string DecalColor
        {
            get { return this._decalColor; }
            set { this._decalColor = value; }
        }

        // Check to see if DecalColor property is set
        internal bool IsSetDecalColor()
        {
            return this._decalColor != null;
        }

        /// <summary>
        /// Gets and sets the property DecalPatternType. 
        /// <para>
        /// Type of pattern used for the decal, such as solid, diagonal, or circular patterns
        /// in various sizes.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SOLID</c>: Solid fill pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIAGONAL_SMALL</c>: Small diagonal stripes pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIAGONAL_MEDIUM</c>: Medium diagonal stripes pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIAGONAL_LARGE</c>: Large diagonal stripes pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIAGONAL_OPPOSITE_SMALL</c>: Small cross-diagonal stripes pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIAGONAL_OPPOSITE_MEDIUM</c>: Medium cross-diagonal stripes pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIAGONAL_OPPOSITE_LARGE</c>: Large cross-diagonal stripes pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CIRCLE_SMALL</c>: Small circle pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CIRCLE_MEDIUM</c>: Medium circle pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CIRCLE_LARGE</c>: Large circle pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIAMOND_SMALL</c>: Small diamonds pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIAMOND_MEDIUM</c>: Medium diamonds pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIAMOND_LARGE</c>: Large diamonds pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIAMOND_GRID_SMALL</c>: Small diamond grid pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIAMOND_GRID_MEDIUM</c>: Medium diamond grid pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIAMOND_GRID_LARGE</c>: Large diamond grid pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CHECKERBOARD_SMALL</c>: Small checkerboard pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CHECKERBOARD_MEDIUM</c>: Medium checkerboard pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CHECKERBOARD_LARGE</c>: Large checkerboard pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRIANGLE_SMALL</c>: Small triangles pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRIANGLE_MEDIUM</c>: Medium triangles pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRIANGLE_LARGE</c>: Large triangles pattern.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DecalPatternType DecalPatternType
        {
            get { return this._decalPatternType; }
            set { this._decalPatternType = value; }
        }

        // Check to see if DecalPatternType property is set
        internal bool IsSetDecalPatternType()
        {
            return this._decalPatternType != null;
        }

        /// <summary>
        /// Gets and sets the property DecalStyleType. 
        /// <para>
        /// Style type for the decal, which can be either manual or automatic. This field is only
        /// applicable for line series.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Manual</c>: Apply manual line and marker configuration for line series.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Auto</c>: Apply automatic line and marker configuration for line series.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DecalStyleType DecalStyleType
        {
            get { return this._decalStyleType; }
            set { this._decalStyleType = value; }
        }

        // Check to see if DecalStyleType property is set
        internal bool IsSetDecalStyleType()
        {
            return this._decalStyleType != null;
        }

        /// <summary>
        /// Gets and sets the property DecalVisibility. 
        /// <para>
        /// Visibility setting for the decal pattern.
        /// </para>
        /// </summary>
        public Visibility DecalVisibility
        {
            get { return this._decalVisibility; }
            set { this._decalVisibility = value; }
        }

        // Check to see if DecalVisibility property is set
        internal bool IsSetDecalVisibility()
        {
            return this._decalVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property ElementValue. 
        /// <para>
        /// Field value of the field that you are setting the decal pattern to. Applicable only
        /// for field level settings.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string ElementValue
        {
            get { return this._elementValue; }
            set { this._elementValue = value; }
        }

        // Check to see if ElementValue property is set
        internal bool IsSetElementValue()
        {
            return this._elementValue != null;
        }

    }
}