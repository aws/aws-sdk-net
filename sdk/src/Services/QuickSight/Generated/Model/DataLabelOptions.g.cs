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
    public partial class DataLabelOptions
    {
        /// <summary>
        /// Gets and sets the property CategoryLabelVisibility. 
        /// <para>
        /// Determines the visibility of the category field labels.
        /// </para>
        /// </summary>
        public Visibility CategoryLabelVisibility { get; set; }

        /// <summary>
        /// Checks to see if the CategoryLabelVisibility property is set.
        /// </summary>
        internal bool IsSetCategoryLabelVisibility() => this.CategoryLabelVisibility != null;

        /// <summary>
        /// Gets and sets the property DataLabelTypes. 
        /// <para>
        /// The option that determines the data label type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<DataLabelType> DataLabelTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<DataLabelType>() : null;

        /// <summary>
        /// Checks to see if the DataLabelTypes property is set.
        /// </summary>
        internal bool IsSetDataLabelTypes() => this.DataLabelTypes != null && (this.DataLabelTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LabelColor. 
        /// <para>
        /// Determines the color of the data labels.
        /// </para>
        /// </summary>
        public string LabelColor { get; set; }

        /// <summary>
        /// Checks to see if the LabelColor property is set.
        /// </summary>
        internal bool IsSetLabelColor() => this.LabelColor != null;

        /// <summary>
        /// Gets and sets the property LabelContent. 
        /// <para>
        /// Determines the content of the data labels.
        /// </para>
        /// </summary>
        public DataLabelContent LabelContent { get; set; }

        /// <summary>
        /// Checks to see if the LabelContent property is set.
        /// </summary>
        internal bool IsSetLabelContent() => this.LabelContent != null;

        /// <summary>
        /// Gets and sets the property LabelFontConfiguration. 
        /// <para>
        /// Determines the font configuration of the data labels.
        /// </para>
        /// </summary>
        public FontConfiguration LabelFontConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LabelFontConfiguration property is set.
        /// </summary>
        internal bool IsSetLabelFontConfiguration() => this.LabelFontConfiguration != null;

        /// <summary>
        /// Gets and sets the property MeasureLabelVisibility. 
        /// <para>
        /// Determines the visibility of the measure field labels.
        /// </para>
        /// </summary>
        public Visibility MeasureLabelVisibility { get; set; }

        /// <summary>
        /// Checks to see if the MeasureLabelVisibility property is set.
        /// </summary>
        internal bool IsSetMeasureLabelVisibility() => this.MeasureLabelVisibility != null;

        /// <summary>
        /// Gets and sets the property Overlap. 
        /// <para>
        /// Determines whether overlap is enabled or disabled for the data labels.
        /// </para>
        /// </summary>
        public DataLabelOverlap Overlap { get; set; }

        /// <summary>
        /// Checks to see if the Overlap property is set.
        /// </summary>
        internal bool IsSetOverlap() => this.Overlap != null;

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// Determines the position of the data labels.
        /// </para>
        /// </summary>
        public DataLabelPosition Position { get; set; }

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null;

        /// <summary>
        /// Gets and sets the property TotalsVisibility. 
        /// <para>
        /// Determines the visibility of the total.
        /// </para>
        /// </summary>
        public Visibility TotalsVisibility { get; set; }

        /// <summary>
        /// Checks to see if the TotalsVisibility property is set.
        /// </summary>
        internal bool IsSetTotalsVisibility() => this.TotalsVisibility != null;

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// Determines the visibility of the data labels.
        /// </para>
        /// </summary>
        public Visibility Visibility { get; set; }

        /// <summary>
        /// Checks to see if the Visibility property is set.
        /// </summary>
        internal bool IsSetVisibility() => this.Visibility != null;
    }
}
