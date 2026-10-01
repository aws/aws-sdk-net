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
    /// The options that determine the presentation of the data labels.
    /// </summary>
    public partial class FunnelChartDataLabelOptions
    {
        /// <summary>
        /// Gets and sets the property CategoryLabelVisibility. 
        /// <para>
        /// The visibility of the category labels within the data labels.
        /// </para>
        /// </summary>
        public Visibility CategoryLabelVisibility { get; set; }

        /// <summary>
        /// Checks to see if the CategoryLabelVisibility property is set.
        /// </summary>
        internal bool IsSetCategoryLabelVisibility() => this.CategoryLabelVisibility != null;

        /// <summary>
        /// Gets and sets the property LabelColor. 
        /// <para>
        /// The color of the data label text.
        /// </para>
        /// </summary>
        public string LabelColor { get; set; }

        /// <summary>
        /// Checks to see if the LabelColor property is set.
        /// </summary>
        internal bool IsSetLabelColor() => this.LabelColor != null;

        /// <summary>
        /// Gets and sets the property LabelFontConfiguration. 
        /// <para>
        /// The font configuration for the data labels.
        /// </para>
        ///  
        /// <para>
        /// Only the <c>FontSize</c> attribute of the font configuration is used for data labels.
        /// </para>
        /// </summary>
        public FontConfiguration LabelFontConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LabelFontConfiguration property is set.
        /// </summary>
        internal bool IsSetLabelFontConfiguration() => this.LabelFontConfiguration != null;

        /// <summary>
        /// Gets and sets the property MeasureDataLabelStyle. 
        /// <para>
        /// Determines the style of the metric labels.
        /// </para>
        /// </summary>
        public FunnelChartMeasureDataLabelStyle MeasureDataLabelStyle { get; set; }

        /// <summary>
        /// Checks to see if the MeasureDataLabelStyle property is set.
        /// </summary>
        internal bool IsSetMeasureDataLabelStyle() => this.MeasureDataLabelStyle != null;

        /// <summary>
        /// Gets and sets the property MeasureLabelVisibility. 
        /// <para>
        /// The visibility of the measure labels within the data labels.
        /// </para>
        /// </summary>
        public Visibility MeasureLabelVisibility { get; set; }

        /// <summary>
        /// Checks to see if the MeasureLabelVisibility property is set.
        /// </summary>
        internal bool IsSetMeasureLabelVisibility() => this.MeasureLabelVisibility != null;

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// Determines the positioning of the data label relative to a section of the funnel.
        /// </para>
        /// </summary>
        public DataLabelPosition Position { get; set; }

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null;

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility option that determines if data labels are displayed.
        /// </para>
        /// </summary>
        public Visibility Visibility { get; set; }

        /// <summary>
        /// Checks to see if the Visibility property is set.
        /// </summary>
        internal bool IsSetVisibility() => this.Visibility != null;
    }
}
