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
    /// The option that corresponds to the control type of the filter.
    /// </summary>
    public partial class DefaultFilterControlOptions
    {
        /// <summary>
        /// Gets and sets the property DefaultDateTimePickerOptions. 
        /// <para>
        /// The default options that correspond to the filter control type of a <c>DateTimePicker</c>.
        /// </para>
        /// </summary>
        public DefaultDateTimePickerControlOptions DefaultDateTimePickerOptions { get; set; }

        /// <summary>
        /// Checks to see if the DefaultDateTimePickerOptions property is set.
        /// </summary>
        internal bool IsSetDefaultDateTimePickerOptions() => this.DefaultDateTimePickerOptions != null;

        /// <summary>
        /// Gets and sets the property DefaultDropdownOptions. 
        /// <para>
        /// The default options that correspond to the <c>Dropdown</c> filter control type.
        /// </para>
        /// </summary>
        public DefaultFilterDropDownControlOptions DefaultDropdownOptions { get; set; }

        /// <summary>
        /// Checks to see if the DefaultDropdownOptions property is set.
        /// </summary>
        internal bool IsSetDefaultDropdownOptions() => this.DefaultDropdownOptions != null;

        /// <summary>
        /// Gets and sets the property DefaultListOptions. 
        /// <para>
        /// The default options that correspond to the <c>List</c> filter control type.
        /// </para>
        /// </summary>
        public DefaultFilterListControlOptions DefaultListOptions { get; set; }

        /// <summary>
        /// Checks to see if the DefaultListOptions property is set.
        /// </summary>
        internal bool IsSetDefaultListOptions() => this.DefaultListOptions != null;

        /// <summary>
        /// Gets and sets the property DefaultRelativeDateTimeOptions. 
        /// <para>
        /// The default options that correspond to the <c>RelativeDateTime</c> filter control
        /// type.
        /// </para>
        /// </summary>
        public DefaultRelativeDateTimeControlOptions DefaultRelativeDateTimeOptions { get; set; }

        /// <summary>
        /// Checks to see if the DefaultRelativeDateTimeOptions property is set.
        /// </summary>
        internal bool IsSetDefaultRelativeDateTimeOptions() => this.DefaultRelativeDateTimeOptions != null;

        /// <summary>
        /// Gets and sets the property DefaultSliderOptions. 
        /// <para>
        /// The default options that correspond to the <c>Slider</c> filter control type.
        /// </para>
        /// </summary>
        public DefaultSliderControlOptions DefaultSliderOptions { get; set; }

        /// <summary>
        /// Checks to see if the DefaultSliderOptions property is set.
        /// </summary>
        internal bool IsSetDefaultSliderOptions() => this.DefaultSliderOptions != null;

        /// <summary>
        /// Gets and sets the property DefaultTextAreaOptions. 
        /// <para>
        /// The default options that correspond to the <c>TextArea</c> filter control type.
        /// </para>
        /// </summary>
        public DefaultTextAreaControlOptions DefaultTextAreaOptions { get; set; }

        /// <summary>
        /// Checks to see if the DefaultTextAreaOptions property is set.
        /// </summary>
        internal bool IsSetDefaultTextAreaOptions() => this.DefaultTextAreaOptions != null;

        /// <summary>
        /// Gets and sets the property DefaultTextFieldOptions. 
        /// <para>
        /// The default options that correspond to the <c>TextField</c> filter control type.
        /// </para>
        /// </summary>
        public DefaultTextFieldControlOptions DefaultTextFieldOptions { get; set; }

        /// <summary>
        /// Checks to see if the DefaultTextFieldOptions property is set.
        /// </summary>
        internal bool IsSetDefaultTextFieldOptions() => this.DefaultTextFieldOptions != null;
    }
}
