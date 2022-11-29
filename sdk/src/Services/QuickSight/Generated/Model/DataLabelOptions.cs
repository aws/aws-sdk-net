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
    public partial class DataLabelOptions
    {
        private Visibility _categoryLabelVisibility;
        private List<DataLabelType> _dataLabelTypes = new List<DataLabelType>();
        private string _labelColor;
        private DataLabelContent _labelContent;
        private FontConfiguration _labelFontConfiguration;
        private Visibility _measureLabelVisibility;
        private DataLabelOverlap _overlap;
        private DataLabelPosition _position;
        private Visibility _visibility;

        /// <summary>
        /// Gets and sets the property CategoryLabelVisibility. 
        /// <para>
        /// Determines the visibility of the category field labels.
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
        /// Gets and sets the property DataLabelTypes. 
        /// <para>
        /// The option that determines the data label type.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<DataLabelType> DataLabelTypes
        {
            get { return this._dataLabelTypes; }
            set { this._dataLabelTypes = value; }
        }

        // Check to see if DataLabelTypes property is set
        internal bool IsSetDataLabelTypes()
        {
            return this._dataLabelTypes != null && this._dataLabelTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LabelColor. 
        /// <para>
        /// Determines the color of the data labels.
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
        /// Gets and sets the property LabelContent. 
        /// <para>
        /// Determines the content of the data labels.
        /// </para>
        /// </summary>
        public DataLabelContent LabelContent
        {
            get { return this._labelContent; }
            set { this._labelContent = value; }
        }

        // Check to see if LabelContent property is set
        internal bool IsSetLabelContent()
        {
            return this._labelContent != null;
        }

        /// <summary>
        /// Gets and sets the property LabelFontConfiguration. 
        /// <para>
        /// Determines the font configuration of the data labels.
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
        /// Gets and sets the property MeasureLabelVisibility. 
        /// <para>
        /// Determines the visibility of the measure field labels.
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
        /// Gets and sets the property Overlap. 
        /// <para>
        /// Determines whether overlap is enabled or disabled for the data labels.
        /// </para>
        /// </summary>
        public DataLabelOverlap Overlap
        {
            get { return this._overlap; }
            set { this._overlap = value; }
        }

        // Check to see if Overlap property is set
        internal bool IsSetOverlap()
        {
            return this._overlap != null;
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// Determines the position of the data labels.
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
        /// Determines the visibility of the data labels.
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