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
    /// Determines the typography options.
    /// </summary>
    public partial class Typography
    {
        /// <summary>
        /// Gets and sets the property AxisLabelFontConfiguration.
        /// </summary>
        public FontConfiguration AxisLabelFontConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AxisLabelFontConfiguration property is set.
        /// </summary>
        internal bool IsSetAxisLabelFontConfiguration() => this.AxisLabelFontConfiguration != null;

        /// <summary>
        /// Gets and sets the property AxisTitleFontConfiguration.
        /// </summary>
        public FontConfiguration AxisTitleFontConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AxisTitleFontConfiguration property is set.
        /// </summary>
        internal bool IsSetAxisTitleFontConfiguration() => this.AxisTitleFontConfiguration != null;

        /// <summary>
        /// Gets and sets the property ControlTitleFontConfiguration. 
        /// <para>
        /// Configures the display properties of the control title.
        /// </para>
        /// </summary>
        public ControlTitleFontConfiguration ControlTitleFontConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ControlTitleFontConfiguration property is set.
        /// </summary>
        internal bool IsSetControlTitleFontConfiguration() => this.ControlTitleFontConfiguration != null;

        /// <summary>
        /// Gets and sets the property DataLabelFontConfiguration.
        /// </summary>
        public FontConfiguration DataLabelFontConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataLabelFontConfiguration property is set.
        /// </summary>
        internal bool IsSetDataLabelFontConfiguration() => this.DataLabelFontConfiguration != null;

        /// <summary>
        /// Gets and sets the property FontFamilies. 
        /// <para>
        /// Determines the list of font families.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<Font> FontFamilies { get; set; } = AWSConfigs.InitializeCollections ? new List<Font>() : null;

        /// <summary>
        /// Checks to see if the FontFamilies property is set.
        /// </summary>
        internal bool IsSetFontFamilies() => this.FontFamilies != null && (this.FontFamilies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LegendTitleFontConfiguration.
        /// </summary>
        public FontConfiguration LegendTitleFontConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LegendTitleFontConfiguration property is set.
        /// </summary>
        internal bool IsSetLegendTitleFontConfiguration() => this.LegendTitleFontConfiguration != null;

        /// <summary>
        /// Gets and sets the property LegendValueFontConfiguration.
        /// </summary>
        public FontConfiguration LegendValueFontConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LegendValueFontConfiguration property is set.
        /// </summary>
        internal bool IsSetLegendValueFontConfiguration() => this.LegendValueFontConfiguration != null;

        /// <summary>
        /// Gets and sets the property VisualSubtitleFontConfiguration. 
        /// <para>
        /// Configures the display properties of the visual sub-title.
        /// </para>
        /// </summary>
        public VisualSubtitleFontConfiguration VisualSubtitleFontConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VisualSubtitleFontConfiguration property is set.
        /// </summary>
        internal bool IsSetVisualSubtitleFontConfiguration() => this.VisualSubtitleFontConfiguration != null;

        /// <summary>
        /// Gets and sets the property VisualTitleFontConfiguration. 
        /// <para>
        /// Configures the display properties of the visual title.
        /// </para>
        /// </summary>
        public VisualTitleFontConfiguration VisualTitleFontConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VisualTitleFontConfiguration property is set.
        /// </summary>
        internal bool IsSetVisualTitleFontConfiguration() => this.VisualTitleFontConfiguration != null;
    }
}
