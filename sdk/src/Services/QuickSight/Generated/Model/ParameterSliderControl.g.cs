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
    /// A control to display a horizontal toggle bar. This is used to change a value by sliding
    /// the toggle.
    /// </summary>
    public partial class ParameterSliderControl
    {
        /// <summary>
        /// Gets and sets the property ControlTitleFormatText. 
        /// <para>
        /// The title text format configuration for the control.
        /// </para>
        /// </summary>
        public ControlTitleFormatText ControlTitleFormatText { get; set; }

        /// <summary>
        /// Checks to see if the ControlTitleFormatText property is set.
        /// </summary>
        internal bool IsSetControlTitleFormatText() => this.ControlTitleFormatText != null;

        /// <summary>
        /// Gets and sets the property DisplayOptions. 
        /// <para>
        /// The display options of a control.
        /// </para>
        /// </summary>
        public SliderControlDisplayOptions DisplayOptions { get; set; }

        /// <summary>
        /// Checks to see if the DisplayOptions property is set.
        /// </summary>
        internal bool IsSetDisplayOptions() => this.DisplayOptions != null;

        /// <summary>
        /// Gets and sets the property MaximumValue. 
        /// <para>
        /// The larger value that is displayed at the right of the slider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? MaximumValue { get; set; }

        /// <summary>
        /// Checks to see if the MaximumValue property is set.
        /// </summary>
        internal bool IsSetMaximumValue() => this.MaximumValue.HasValue;

        /// <summary>
        /// Gets and sets the property MinimumValue. 
        /// <para>
        /// The smaller value that is displayed at the left of the slider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? MinimumValue { get; set; }

        /// <summary>
        /// Checks to see if the MinimumValue property is set.
        /// </summary>
        internal bool IsSetMinimumValue() => this.MinimumValue.HasValue;

        /// <summary>
        /// Gets and sets the property ParameterControlId. 
        /// <para>
        /// The ID of the <c>ParameterSliderControl</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ParameterControlId { get; set; }

        /// <summary>
        /// Checks to see if the ParameterControlId property is set.
        /// </summary>
        internal bool IsSetParameterControlId() => this.ParameterControlId != null;

        /// <summary>
        /// Gets and sets the property SourceParameterName. 
        /// <para>
        /// The source parameter name of the <c>ParameterSliderControl</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string SourceParameterName { get; set; }

        /// <summary>
        /// Checks to see if the SourceParameterName property is set.
        /// </summary>
        internal bool IsSetSourceParameterName() => this.SourceParameterName != null;

        /// <summary>
        /// Gets and sets the property StepSize. 
        /// <para>
        /// The number of increments that the slider bar is divided into.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? StepSize { get; set; }

        /// <summary>
        /// Checks to see if the StepSize property is set.
        /// </summary>
        internal bool IsSetStepSize() => this.StepSize.HasValue;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the <c>ParameterSliderControl</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
