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
    /// The default options that correspond to the <c>Slider</c> filter control type.
    /// </summary>
    public partial class DefaultSliderControlOptions
    {
        private SliderControlDisplayOptions _displayOptions;
        private double? _maximumValue;
        private double? _minimumValue;
        private double? _stepSize;
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
        /// Gets and sets the property MaximumValue. 
        /// <para>
        /// The larger value that is displayed at the right of the slider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? MaximumValue
        {
            get { return this._maximumValue; }
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
        /// The smaller value that is displayed at the left of the slider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? MinimumValue
        {
            get { return this._minimumValue; }
            set { this._minimumValue = value; }
        }

        // Check to see if MinimumValue property is set
        internal bool IsSetMinimumValue()
        {
            return this._minimumValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StepSize. 
        /// <para>
        /// The number of increments that the slider bar is divided into.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? StepSize
        {
            get { return this._stepSize; }
            set { this._stepSize = value; }
        }

        // Check to see if StepSize property is set
        internal bool IsSetStepSize()
        {
            return this._stepSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the <c>DefaultSliderControlOptions</c>. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SINGLE_POINT</c>: Filter against(equals) a single data point.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RANGE</c>: Filter data that is in a specified range.
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