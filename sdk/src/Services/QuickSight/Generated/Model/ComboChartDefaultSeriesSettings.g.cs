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
    /// The options that determine the default presentation of all series in <c>ComboChartVisual</c>.
    /// </summary>
    public partial class ComboChartDefaultSeriesSettings
    {
        /// <summary>
        /// Gets and sets the property BorderSettings. 
        /// <para>
        /// Border settings for all bar series in the visual.
        /// </para>
        /// </summary>
        public BorderSettings BorderSettings { get; set; }

        /// <summary>
        /// Checks to see if the BorderSettings property is set.
        /// </summary>
        internal bool IsSetBorderSettings() => this.BorderSettings != null;

        /// <summary>
        /// Gets and sets the property DecalSettings. 
        /// <para>
        /// Decal settings for all series in the visual.
        /// </para>
        /// </summary>
        public DecalSettings DecalSettings { get; set; }

        /// <summary>
        /// Checks to see if the DecalSettings property is set.
        /// </summary>
        internal bool IsSetDecalSettings() => this.DecalSettings != null;

        /// <summary>
        /// Gets and sets the property LineStyleSettings. 
        /// <para>
        /// Line styles options for all line series in the visual.
        /// </para>
        /// </summary>
        public LineChartLineStyleSettings LineStyleSettings { get; set; }

        /// <summary>
        /// Checks to see if the LineStyleSettings property is set.
        /// </summary>
        internal bool IsSetLineStyleSettings() => this.LineStyleSettings != null;

        /// <summary>
        /// Gets and sets the property MarkerStyleSettings. 
        /// <para>
        /// Marker styles options for all line series in the visual.
        /// </para>
        /// </summary>
        public LineChartMarkerStyleSettings MarkerStyleSettings { get; set; }

        /// <summary>
        /// Checks to see if the MarkerStyleSettings property is set.
        /// </summary>
        internal bool IsSetMarkerStyleSettings() => this.MarkerStyleSettings != null;
    }
}
