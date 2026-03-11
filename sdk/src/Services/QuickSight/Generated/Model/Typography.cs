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
    /// Determines the typography options.
    /// </summary>
    public partial class Typography
    {
        private FontConfiguration _axisLabelFontConfiguration;
        private FontConfiguration _axisTitleFontConfiguration;
        private FontConfiguration _dataLabelFontConfiguration;
        private List<Font> _fontFamilies = AWSConfigs.InitializeCollections ? new List<Font>() : null;
        private FontConfiguration _legendTitleFontConfiguration;
        private FontConfiguration _legendValueFontConfiguration;
        private VisualSubtitleFontConfiguration _visualSubtitleFontConfiguration;
        private VisualTitleFontConfiguration _visualTitleFontConfiguration;

        /// <summary>
        /// Gets and sets the property AxisLabelFontConfiguration.
        /// </summary>
        public FontConfiguration AxisLabelFontConfiguration
        {
            get { return this._axisLabelFontConfiguration; }
            set { this._axisLabelFontConfiguration = value; }
        }

        // Check to see if AxisLabelFontConfiguration property is set
        internal bool IsSetAxisLabelFontConfiguration()
        {
            return this._axisLabelFontConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AxisTitleFontConfiguration.
        /// </summary>
        public FontConfiguration AxisTitleFontConfiguration
        {
            get { return this._axisTitleFontConfiguration; }
            set { this._axisTitleFontConfiguration = value; }
        }

        // Check to see if AxisTitleFontConfiguration property is set
        internal bool IsSetAxisTitleFontConfiguration()
        {
            return this._axisTitleFontConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DataLabelFontConfiguration.
        /// </summary>
        public FontConfiguration DataLabelFontConfiguration
        {
            get { return this._dataLabelFontConfiguration; }
            set { this._dataLabelFontConfiguration = value; }
        }

        // Check to see if DataLabelFontConfiguration property is set
        internal bool IsSetDataLabelFontConfiguration()
        {
            return this._dataLabelFontConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property FontFamilies. 
        /// <para>
        /// Determines the list of font families.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=5)]
        public List<Font> FontFamilies
        {
            get { return this._fontFamilies; }
            set { this._fontFamilies = value; }
        }

        // Check to see if FontFamilies property is set
        internal bool IsSetFontFamilies()
        {
            return this._fontFamilies != null && (this._fontFamilies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LegendTitleFontConfiguration.
        /// </summary>
        public FontConfiguration LegendTitleFontConfiguration
        {
            get { return this._legendTitleFontConfiguration; }
            set { this._legendTitleFontConfiguration = value; }
        }

        // Check to see if LegendTitleFontConfiguration property is set
        internal bool IsSetLegendTitleFontConfiguration()
        {
            return this._legendTitleFontConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LegendValueFontConfiguration.
        /// </summary>
        public FontConfiguration LegendValueFontConfiguration
        {
            get { return this._legendValueFontConfiguration; }
            set { this._legendValueFontConfiguration = value; }
        }

        // Check to see if LegendValueFontConfiguration property is set
        internal bool IsSetLegendValueFontConfiguration()
        {
            return this._legendValueFontConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property VisualSubtitleFontConfiguration. 
        /// <para>
        /// Configures the display properties of the visual sub-title.
        /// </para>
        /// </summary>
        public VisualSubtitleFontConfiguration VisualSubtitleFontConfiguration
        {
            get { return this._visualSubtitleFontConfiguration; }
            set { this._visualSubtitleFontConfiguration = value; }
        }

        // Check to see if VisualSubtitleFontConfiguration property is set
        internal bool IsSetVisualSubtitleFontConfiguration()
        {
            return this._visualSubtitleFontConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property VisualTitleFontConfiguration. 
        /// <para>
        /// Configures the display properties of the visual title.
        /// </para>
        /// </summary>
        public VisualTitleFontConfiguration VisualTitleFontConfiguration
        {
            get { return this._visualTitleFontConfiguration; }
            set { this._visualTitleFontConfiguration = value; }
        }

        // Check to see if VisualTitleFontConfiguration property is set
        internal bool IsSetVisualTitleFontConfiguration()
        {
            return this._visualTitleFontConfiguration != null;
        }

    }
}