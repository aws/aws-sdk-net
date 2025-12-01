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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains color configuration for header elements in a workspace theme.
    /// </summary>
    public partial class PaletteHeader
    {
        private string _background;
        private bool? _invertActionsColors;
        private string _text;
        private string _textHover;

        /// <summary>
        /// Gets and sets the property Background. 
        /// <para>
        /// The background color of the header.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string Background
        {
            get { return this._background; }
            set { this._background = value; }
        }

        // Check to see if Background property is set
        internal bool IsSetBackground()
        {
            return this._background != null;
        }

        /// <summary>
        /// Gets and sets the property InvertActionsColors. 
        /// <para>
        /// Whether to invert the colors of action buttons in the header.
        /// </para>
        /// </summary>
        public bool InvertActionsColors
        {
            get { return this._invertActionsColors.GetValueOrDefault(); }
            set { this._invertActionsColors = value; }
        }

        // Check to see if InvertActionsColors property is set
        internal bool IsSetInvertActionsColors()
        {
            return this._invertActionsColors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text color in the header.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

        /// <summary>
        /// Gets and sets the property TextHover. 
        /// <para>
        /// The text color when hovering over header elements.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string TextHover
        {
            get { return this._textHover; }
            set { this._textHover = value; }
        }

        // Check to see if TextHover property is set
        internal bool IsSetTextHover()
        {
            return this._textHover != null;
        }

    }
}