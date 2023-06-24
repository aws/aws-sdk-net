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
    /// A control to display a horizontal toggle bar. This is used to change a value by sliding
    /// the toggle.
    /// </summary>
    public partial class FilterSliderControl
    {
        private SliderControlDisplayOptions _displayOptions;
        private string _filterControlId;
        private double? _maximumValue;
        private double? _minimumValue;
        private string _sourceFilterId;
        private double? _stepSize;
        private string _title;
        private SheetControlSliderType _type;

        /// <summary>
        /// Gets and sets the property DisplayOptions. 
        /// <para>
        /// The display options of a control.
        /// </para>
        /// </summary>
        public SliderControlDisplayOptions DisplayOptions
        {
            get { return this._displayOptions; }
            set { this._displayOptions = value; }
        }

        // Check to see if DisplayOptions property is set
        internal bool IsSetDisplayOptions()
        {
            return this._displayOptions != null;
        }

        /// <summary>
        /// Gets and sets the property FilterControlId. 
        /// <para>
        /// The ID of the <code>FilterSliderControl</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string FilterControlId
        {
            get { return this._filterControlId; }
            set { this._filterControlId = value; }
        }

        // Check to see if FilterControlId property is set
        internal bool IsSetFilterControlId()
        {
            return this._filterControlId != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumValue. 
        /// <para>
        /// The smaller value that is displayed at the left of the slider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double MaximumValue
        {
            get { return this._maximumValue.GetValueOrDefault(); }
            set { this._maximumValue = value; }
        }

        // Check to see if MaximumValue property is set
        internal bool IsSetMaximumValue()
        {
            return this._maximumValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumValue. 
        /// <para>
        /// The larger value that is displayed at the right of the slider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double MinimumValue
        {
            get { return this._minimumValue.GetValueOrDefault(); }
            set { this._minimumValue = value; }
        }

        // Check to see if MinimumValue property is set
        internal bool IsSetMinimumValue()
        {
            return this._minimumValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceFilterId. 
        /// <para>
        /// The source filter ID of the <code>FilterSliderControl</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string SourceFilterId
        {
            get { return this._sourceFilterId; }
            set { this._sourceFilterId = value; }
        }

        // Check to see if SourceFilterId property is set
        internal bool IsSetSourceFilterId()
        {
            return this._sourceFilterId != null;
        }

        /// <summary>
        /// Gets and sets the property StepSize. 
        /// <para>
        /// The number of increments that the slider bar is divided into.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double StepSize
        {
            get { return this._stepSize.GetValueOrDefault(); }
            set { this._stepSize = value; }
        }

        // Check to see if StepSize property is set
        internal bool IsSetStepSize()
        {
            return this._stepSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the <code>FilterSliderControl</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of <code>FilterSliderControl</code>. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SINGLE_POINT</code>: Filter against(equals) a single data point.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RANGE</code>: Filter data that is in a specified range.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SheetControlSliderType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}