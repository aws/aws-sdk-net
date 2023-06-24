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
    /// The label configuration of a reference line.
    /// </summary>
    public partial class ReferenceLineLabelConfiguration
    {
        private ReferenceLineCustomLabelConfiguration _customLabelConfiguration;
        private string _fontColor;
        private FontConfiguration _fontConfiguration;
        private ReferenceLineLabelHorizontalPosition _horizontalPosition;
        private ReferenceLineValueLabelConfiguration _valueLabelConfiguration;
        private ReferenceLineLabelVerticalPosition _verticalPosition;

        /// <summary>
        /// Gets and sets the property CustomLabelConfiguration. 
        /// <para>
        /// The custom label configuration of the label in a reference line.
        /// </para>
        /// </summary>
        public ReferenceLineCustomLabelConfiguration CustomLabelConfiguration
        {
            get { return this._customLabelConfiguration; }
            set { this._customLabelConfiguration = value; }
        }

        // Check to see if CustomLabelConfiguration property is set
        internal bool IsSetCustomLabelConfiguration()
        {
            return this._customLabelConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property FontColor. 
        /// <para>
        /// The font color configuration of the label in a reference line.
        /// </para>
        /// </summary>
        public string FontColor
        {
            get { return this._fontColor; }
            set { this._fontColor = value; }
        }

        // Check to see if FontColor property is set
        internal bool IsSetFontColor()
        {
            return this._fontColor != null;
        }

        /// <summary>
        /// Gets and sets the property FontConfiguration. 
        /// <para>
        /// The font configuration of the label in a reference line.
        /// </para>
        /// </summary>
        public FontConfiguration FontConfiguration
        {
            get { return this._fontConfiguration; }
            set { this._fontConfiguration = value; }
        }

        // Check to see if FontConfiguration property is set
        internal bool IsSetFontConfiguration()
        {
            return this._fontConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property HorizontalPosition. 
        /// <para>
        /// The horizontal position configuration of the label in a reference line. Choose one
        /// of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>LEFT</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CENTER</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RIGHT</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReferenceLineLabelHorizontalPosition HorizontalPosition
        {
            get { return this._horizontalPosition; }
            set { this._horizontalPosition = value; }
        }

        // Check to see if HorizontalPosition property is set
        internal bool IsSetHorizontalPosition()
        {
            return this._horizontalPosition != null;
        }

        /// <summary>
        /// Gets and sets the property ValueLabelConfiguration. 
        /// <para>
        /// The value label configuration of the label in a reference line.
        /// </para>
        /// </summary>
        public ReferenceLineValueLabelConfiguration ValueLabelConfiguration
        {
            get { return this._valueLabelConfiguration; }
            set { this._valueLabelConfiguration = value; }
        }

        // Check to see if ValueLabelConfiguration property is set
        internal bool IsSetValueLabelConfiguration()
        {
            return this._valueLabelConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property VerticalPosition. 
        /// <para>
        /// The vertical position configuration of the label in a reference line. Choose one of
        /// the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ABOVE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BELOW</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReferenceLineLabelVerticalPosition VerticalPosition
        {
            get { return this._verticalPosition; }
            set { this._verticalPosition = value; }
        }

        // Check to see if VerticalPosition property is set
        internal bool IsSetVerticalPosition()
        {
            return this._verticalPosition != null;
        }

    }
}