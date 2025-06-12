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
    /// The theme colors that are used for data colors in charts. The colors description is
    /// a hexadecimal color code that consists of six alphanumerical characters, prefixed
    /// with <c>#</c>, for example #37BFF5.
    /// </summary>
    public partial class DataColorPalette
    {
        private List<string> _colors = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _emptyFillColor;
        private List<string> _minMaxGradient = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Colors. 
        /// <para>
        /// The hexadecimal codes for the colors.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._colors != null && (this._colors.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._minMaxGradient != null && (this._minMaxGradient.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}