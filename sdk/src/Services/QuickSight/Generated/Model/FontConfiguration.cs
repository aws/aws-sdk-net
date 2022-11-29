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
    /// Configures the display properties of the given text.
    /// </summary>
    public partial class FontConfiguration
    {
        private string _fontColor;
        private FontDecoration _fontDecoration;
        private FontSize _fontSize;
        private FontStyle _fontStyle;
        private FontWeight _fontWeight;

        /// <summary>
        /// Gets and sets the property FontColor. 
        /// <para>
        /// Determines the color of the text.
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
        /// Gets and sets the property FontDecoration. 
        /// <para>
        /// Determines the appearance of decorative lines on the text.
        /// </para>
        /// </summary>
        public FontDecoration FontDecoration
        {
            get { return this._fontDecoration; }
            set { this._fontDecoration = value; }
        }

        // Check to see if FontDecoration property is set
        internal bool IsSetFontDecoration()
        {
            return this._fontDecoration != null;
        }

        /// <summary>
        /// Gets and sets the property FontSize. 
        /// <para>
        /// The option that determines the text display size.
        /// </para>
        /// </summary>
        public FontSize FontSize
        {
            get { return this._fontSize; }
            set { this._fontSize = value; }
        }

        // Check to see if FontSize property is set
        internal bool IsSetFontSize()
        {
            return this._fontSize != null;
        }

        /// <summary>
        /// Gets and sets the property FontStyle. 
        /// <para>
        /// Determines the text display face that is inherited by the given font family.
        /// </para>
        /// </summary>
        public FontStyle FontStyle
        {
            get { return this._fontStyle; }
            set { this._fontStyle = value; }
        }

        // Check to see if FontStyle property is set
        internal bool IsSetFontStyle()
        {
            return this._fontStyle != null;
        }

        /// <summary>
        /// Gets and sets the property FontWeight. 
        /// <para>
        /// The option that determines the text display weight, or boldness.
        /// </para>
        /// </summary>
        public FontWeight FontWeight
        {
            get { return this._fontWeight; }
            set { this._fontWeight = value; }
        }

        // Check to see if FontWeight property is set
        internal bool IsSetFontWeight()
        {
            return this._fontWeight != null;
        }

    }
}