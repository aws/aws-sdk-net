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
    /// The map style properties for a map.
    /// </summary>
    public partial class GeospatialMapStyle
    {
        /// <summary>
        /// Gets and sets the property BackgroundColor. 
        /// <para>
        /// The background color and opacity values for a map.
        /// </para>
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Checks to see if the BackgroundColor property is set.
        /// </summary>
        internal bool IsSetBackgroundColor() => this.BackgroundColor != null;

        /// <summary>
        /// Gets and sets the property BaseMapStyle. 
        /// <para>
        /// The selected base map style.
        /// </para>
        /// </summary>
        public BaseMapStyleType BaseMapStyle { get; set; }

        /// <summary>
        /// Checks to see if the BaseMapStyle property is set.
        /// </summary>
        internal bool IsSetBaseMapStyle() => this.BaseMapStyle != null;

        /// <summary>
        /// Gets and sets the property BaseMapVisibility. 
        /// <para>
        /// The state of visibility for the base map.
        /// </para>
        /// </summary>
        public Visibility BaseMapVisibility { get; set; }

        /// <summary>
        /// Checks to see if the BaseMapVisibility property is set.
        /// </summary>
        internal bool IsSetBaseMapVisibility() => this.BaseMapVisibility != null;
    }
}
