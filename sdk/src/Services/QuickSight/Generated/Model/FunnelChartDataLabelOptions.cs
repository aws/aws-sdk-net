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
    /// The options that determine the presentation of the data labels.
    /// </summary>
    public partial class FunnelChartDataLabelOptions
    {
        private Visibility _categoryLabelVisibility;
        private string _labelColor;
        private FontConfiguration _labelFontConfiguration;
        private FunnelChartMeasureDataLabelStyle _measureDataLabelStyle;
        private Visibility _measureLabelVisibility;
        private DataLabelPosition _position;
        private Visibility _visibility;

        /// <summary>
        /// Gets and sets the property CategoryLabelVisibility. 
        /// <para>
        /// The visibility of the category labels within the data labels.
        /// </para>
        /// </summary>
        public Visibility CategoryLabelVisibility
        {
            get { return this._categoryLabelVisibility; }
            set { this._categoryLabelVisibility = value; }
        }

        // Check to see if CategoryLabelVisibility property is set
        internal bool IsSetCategoryLabelVisibility()
        {
            return this._categoryLabelVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property LabelColor. 
        /// <para>
        /// The color of the data label text.
        /// </para>
        /// </summary>
        public string LabelColor
        {
            get { return this._labelColor; }
            set { this._labelColor = value; }
        }

        // Check to see if LabelColor property is set
        internal bool IsSetLabelColor()
        {
            return this._labelColor != null;
        }

        /// <summary>
        /// Gets and sets the property LabelFontConfiguration. 
        /// <para>
        /// The font configuration for the data labels.
        /// </para>
        ///  
        /// <para>
        /// Only the <code>FontSize</code> attribute of the font configuration is used for data
        /// labels.
        /// </para>
        /// </summary>
        public FontConfiguration LabelFontConfiguration
        {
            get { return this._labelFontConfiguration; }
            set { this._labelFontConfiguration = value; }
        }

        // Check to see if LabelFontConfiguration property is set
        internal bool IsSetLabelFontConfiguration()
        {
            return this._labelFontConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MeasureDataLabelStyle. 
        /// <para>
        /// Determines the style of the metric labels.
        /// </para>
        /// </summary>
        public FunnelChartMeasureDataLabelStyle MeasureDataLabelStyle
        {
            get { return this._measureDataLabelStyle; }
            set { this._measureDataLabelStyle = value; }
        }

        // Check to see if MeasureDataLabelStyle property is set
        internal bool IsSetMeasureDataLabelStyle()
        {
            return this._measureDataLabelStyle != null;
        }

        /// <summary>
        /// Gets and sets the property MeasureLabelVisibility. 
        /// <para>
        /// The visibility of the measure labels within the data labels.
        /// </para>
        /// </summary>
        public Visibility MeasureLabelVisibility
        {
            get { return this._measureLabelVisibility; }
            set { this._measureLabelVisibility = value; }
        }

        // Check to see if MeasureLabelVisibility property is set
        internal bool IsSetMeasureLabelVisibility()
        {
            return this._measureLabelVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// Determines the positioning of the data label relative to a section of the funnel.
        /// </para>
        /// </summary>
        public DataLabelPosition Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility option that determines if data labels are displayed.
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