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
    /// The table cell style for a cell in pivot table or table visual.
    /// </summary>
    public partial class TableCellStyle
    {
        /// <summary>
        /// Gets and sets the property BackgroundColor. 
        /// <para>
        /// The background color for the table cells.
        /// </para>
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Checks to see if the BackgroundColor property is set.
        /// </summary>
        internal bool IsSetBackgroundColor() => this.BackgroundColor != null;

        /// <summary>
        /// Gets and sets the property Border. 
        /// <para>
        /// The borders for the table cells.
        /// </para>
        /// </summary>
        public GlobalTableBorderOptions Border { get; set; }

        /// <summary>
        /// Checks to see if the Border property is set.
        /// </summary>
        internal bool IsSetBorder() => this.Border != null;

        /// <summary>
        /// Gets and sets the property FontConfiguration. 
        /// <para>
        /// The font configuration of the table cells.
        /// </para>
        /// </summary>
        public FontConfiguration FontConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FontConfiguration property is set.
        /// </summary>
        internal bool IsSetFontConfiguration() => this.FontConfiguration != null;

        /// <summary>
        /// Gets and sets the property Height. 
        /// <para>
        /// The height color for the table cells.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 500)]
        public int? Height { get; set; }

        /// <summary>
        /// Checks to see if the Height property is set.
        /// </summary>
        internal bool IsSetHeight() => this.Height.HasValue;

        /// <summary>
        /// Gets and sets the property HorizontalTextAlignment. 
        /// <para>
        /// The horizontal text alignment (left, center, right, auto) for the table cells.
        /// </para>
        /// </summary>
        public HorizontalTextAlignment HorizontalTextAlignment { get; set; }

        /// <summary>
        /// Checks to see if the HorizontalTextAlignment property is set.
        /// </summary>
        internal bool IsSetHorizontalTextAlignment() => this.HorizontalTextAlignment != null;

        /// <summary>
        /// Gets and sets the property TextWrap. 
        /// <para>
        /// The text wrap (none, wrap) for the table cells.
        /// </para>
        /// </summary>
        public TextWrap TextWrap { get; set; }

        /// <summary>
        /// Checks to see if the TextWrap property is set.
        /// </summary>
        internal bool IsSetTextWrap() => this.TextWrap != null;

        /// <summary>
        /// Gets and sets the property VerticalTextAlignment. 
        /// <para>
        /// The vertical text alignment (top, middle, bottom) for the table cells.
        /// </para>
        /// </summary>
        public VerticalTextAlignment VerticalTextAlignment { get; set; }

        /// <summary>
        /// Checks to see if the VerticalTextAlignment property is set.
        /// </summary>
        internal bool IsSetVerticalTextAlignment() => this.VerticalTextAlignment != null;

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility of the table cells.
        /// </para>
        /// </summary>
        public Visibility Visibility { get; set; }

        /// <summary>
        /// Checks to see if the Visibility property is set.
        /// </summary>
        internal bool IsSetVisibility() => this.Visibility != null;
    }
}
