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
    /// Configures the display properties of the visual sub-title.
    /// </summary>
    public partial class VisualSubtitleFontConfiguration
    {
        private FontConfiguration _fontConfiguration;
        private HorizontalTextAlignment _textAlignment;
        private TextTransform _textTransform;

        /// <summary>
        /// Gets and sets the property FontConfiguration.
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
        /// Gets and sets the property TextAlignment. 
        /// <para>
        /// Determines the alignment of visual sub-title.
        /// </para>
        /// </summary>
        public HorizontalTextAlignment TextAlignment
        {
            get { return this._textAlignment; }
            set { this._textAlignment = value; }
        }

        // Check to see if TextAlignment property is set
        internal bool IsSetTextAlignment()
        {
            return this._textAlignment != null;
        }

        /// <summary>
        /// Gets and sets the property TextTransform. 
        /// <para>
        /// Determines the text transformation of visual sub-title.
        /// </para>
        /// </summary>
        public TextTransform TextTransform
        {
            get { return this._textTransform; }
            set { this._textTransform = value; }
        }

        // Check to see if TextTransform property is set
        internal bool IsSetTextTransform()
        {
            return this._textTransform != null;
        }

    }
}