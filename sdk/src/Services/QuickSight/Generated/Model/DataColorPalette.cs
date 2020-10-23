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
    /// The theme colors that are used for data colors in charts. The colors description is
    /// a hexadecimal color code that consists of six alphanumerical characters, prefixed
    /// with <code>#</code>, for example #37BFF5.
    /// </summary>
    public partial class DataColorPalette
    {
        private List<string> _colors = new List<string>();
        private string _emptyFillColor;
        private List<string> _minMaxGradient = new List<string>();

        /// <summary>
        /// Gets and sets the property Colors. 
        /// <para>
        /// The hexadecimal codes for the colors.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<string> Colors
        {
            get { return this._colors; }
            set { this._colors = value; }
        }

        // Check to see if Colors property is set
        internal bool IsSetColors()
        {
            return this._colors != null && this._colors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EmptyFillColor. 
        /// <para>
        /// The hexadecimal code of a color that applies to charts where a lack of data is highlighted.
        /// </para>
        /// </summary>
        public string EmptyFillColor
        {
            get { return this._emptyFillColor; }
            set { this._emptyFillColor = value; }
        }

        // Check to see if EmptyFillColor property is set
        internal bool IsSetEmptyFillColor()
        {
            return this._emptyFillColor != null;
        }

        /// <summary>
        /// Gets and sets the property MinMaxGradient. 
        /// <para>
        /// The minimum and maximum hexadecimal codes that describe a color gradient. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<string> MinMaxGradient
        {
            get { return this._minMaxGradient; }
            set { this._minMaxGradient = value; }
        }

        // Check to see if MinMaxGradient property is set
        internal bool IsSetMinMaxGradient()
        {
            return this._minMaxGradient != null && this._minMaxGradient.Count > 0; 
        }

    }
}