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
    /// The map style properties for a map.
    /// </summary>
    public partial class GeospatialMapStyle
    {
        private string _backgroundColor;
        private BaseMapStyleType _baseMapStyle;
        private Visibility _baseMapVisibility;

        /// <summary>
        /// Gets and sets the property BackgroundColor. 
        /// <para>
        /// The background color and opacity values for a map.
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
        /// Gets and sets the property BaseMapStyle. 
        /// <para>
        /// The selected base map style.
        /// </para>
        /// </summary>
        public BaseMapStyleType BaseMapStyle
        {
            get { return this._baseMapStyle; }
            set { this._baseMapStyle = value; }
        }

        // Check to see if BaseMapStyle property is set
        internal bool IsSetBaseMapStyle()
        {
            return this._baseMapStyle != null;
        }

        /// <summary>
        /// Gets and sets the property BaseMapVisibility. 
        /// <para>
        /// The state of visibility for the base map.
        /// </para>
        /// </summary>
        public Visibility BaseMapVisibility
        {
            get { return this._baseMapVisibility; }
            set { this._baseMapVisibility = value; }
        }

        // Check to see if BaseMapVisibility property is set
        internal bool IsSetBaseMapVisibility()
        {
            return this._baseMapVisibility != null;
        }

    }
}