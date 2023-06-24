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
    /// The table cell style for a cell in pivot table or table visual.
    /// </summary>
    public partial class TableCellStyle
    {
        private string _backgroundColor;
        private GlobalTableBorderOptions _border;
        private FontConfiguration _fontConfiguration;
        private int? _height;
        private HorizontalTextAlignment _horizontalTextAlignment;
        private TextWrap _textWrap;
        private VerticalTextAlignment _verticalTextAlignment;
        private Visibility _visibility;

        /// <summary>
        /// Gets and sets the property BackgroundColor. 
        /// <para>
        /// The background color for the table cells.
        /// </para>
        /// </summary>
        public string BackgroundColor
        {
            get { return this._backgroundColor; }
            set { this._backgroundColor = value; }
        }

        // Check to see if BackgroundColor property is set
        internal bool IsSetBackgroundColor()
        {
            return this._backgroundColor != null;
        }

        /// <summary>
        /// Gets and sets the property Border. 
        /// <para>
        /// The borders for the table cells.
        /// </para>
        /// </summary>
        public GlobalTableBorderOptions Border
        {
            get { return this._border; }
            set { this._border = value; }
        }

        // Check to see if Border property is set
        internal bool IsSetBorder()
        {
            return this._border != null;
        }

        /// <summary>
        /// Gets and sets the property FontConfiguration. 
        /// <para>
        /// The font configuration of the table cells.
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
        /// Gets and sets the property Height. 
        /// <para>
        /// The height color for the table cells.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=500)]
        public int Height
        {
            get { return this._height.GetValueOrDefault(); }
            set { this._height = value; }
        }

        // Check to see if Height property is set
        internal bool IsSetHeight()
        {
            return this._height.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HorizontalTextAlignment. 
        /// <para>
        /// The horizontal text alignment (left, center, right, auto) for the table cells.
        /// </para>
        /// </summary>
        public HorizontalTextAlignment HorizontalTextAlignment
        {
            get { return this._horizontalTextAlignment; }
            set { this._horizontalTextAlignment = value; }
        }

        // Check to see if HorizontalTextAlignment property is set
        internal bool IsSetHorizontalTextAlignment()
        {
            return this._horizontalTextAlignment != null;
        }

        /// <summary>
        /// Gets and sets the property TextWrap. 
        /// <para>
        /// The text wrap (none, wrap) for the table cells.
        /// </para>
        /// </summary>
        public TextWrap TextWrap
        {
            get { return this._textWrap; }
            set { this._textWrap = value; }
        }

        // Check to see if TextWrap property is set
        internal bool IsSetTextWrap()
        {
            return this._textWrap != null;
        }

        /// <summary>
        /// Gets and sets the property VerticalTextAlignment. 
        /// <para>
        /// The vertical text alignment (top, middle, bottom) for the table cells.
        /// </para>
        /// </summary>
        public VerticalTextAlignment VerticalTextAlignment
        {
            get { return this._verticalTextAlignment; }
            set { this._verticalTextAlignment = value; }
        }

        // Check to see if VerticalTextAlignment property is set
        internal bool IsSetVerticalTextAlignment()
        {
            return this._verticalTextAlignment != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility of the table cells.
        /// </para>
        /// </summary>
        public Visibility Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

    }
}