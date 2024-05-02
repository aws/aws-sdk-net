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
    /// The option that corresponds to the control type of the filter.
    /// </summary>
    public partial class DefaultFilterControlOptions
    {
        private DefaultDateTimePickerControlOptions _defaultDateTimePickerOptions;
        private DefaultFilterDropDownControlOptions _defaultDropdownOptions;
        private DefaultFilterListControlOptions _defaultListOptions;
        private DefaultRelativeDateTimeControlOptions _defaultRelativeDateTimeOptions;
        private DefaultSliderControlOptions _defaultSliderOptions;
        private DefaultTextAreaControlOptions _defaultTextAreaOptions;
        private DefaultTextFieldControlOptions _defaultTextFieldOptions;

        /// <summary>
        /// Gets and sets the property DefaultDateTimePickerOptions. 
        /// <para>
        /// The default options that correspond to the filter control type of a <c>DateTimePicker</c>.
        /// </para>
        /// </summary>
        public DefaultDateTimePickerControlOptions DefaultDateTimePickerOptions
        {
            get { return this._defaultDateTimePickerOptions; }
            set { this._defaultDateTimePickerOptions = value; }
        }

        // Check to see if DefaultDateTimePickerOptions property is set
        internal bool IsSetDefaultDateTimePickerOptions()
        {
            return this._defaultDateTimePickerOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultDropdownOptions. 
        /// <para>
        /// The default options that correspond to the <c>Dropdown</c> filter control type.
        /// </para>
        /// </summary>
        public DefaultFilterDropDownControlOptions DefaultDropdownOptions
        {
            get { return this._defaultDropdownOptions; }
            set { this._defaultDropdownOptions = value; }
        }

        // Check to see if DefaultDropdownOptions property is set
        internal bool IsSetDefaultDropdownOptions()
        {
            return this._defaultDropdownOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultListOptions. 
        /// <para>
        /// The default options that correspond to the <c>List</c> filter control type.
        /// </para>
        /// </summary>
        public DefaultFilterListControlOptions DefaultListOptions
        {
            get { return this._defaultListOptions; }
            set { this._defaultListOptions = value; }
        }

        // Check to see if DefaultListOptions property is set
        internal bool IsSetDefaultListOptions()
        {
            return this._defaultListOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultRelativeDateTimeOptions. 
        /// <para>
        /// The default options that correspond to the <c>RelativeDateTime</c> filter control
        /// type.
        /// </para>
        /// </summary>
        public DefaultRelativeDateTimeControlOptions DefaultRelativeDateTimeOptions
        {
            get { return this._defaultRelativeDateTimeOptions; }
            set { this._defaultRelativeDateTimeOptions = value; }
        }

        // Check to see if DefaultRelativeDateTimeOptions property is set
        internal bool IsSetDefaultRelativeDateTimeOptions()
        {
            return this._defaultRelativeDateTimeOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultSliderOptions. 
        /// <para>
        /// The default options that correspond to the <c>Slider</c> filter control type.
        /// </para>
        /// </summary>
        public DefaultSliderControlOptions DefaultSliderOptions
        {
            get { return this._defaultSliderOptions; }
            set { this._defaultSliderOptions = value; }
        }

        // Check to see if DefaultSliderOptions property is set
        internal bool IsSetDefaultSliderOptions()
        {
            return this._defaultSliderOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultTextAreaOptions. 
        /// <para>
        /// The default options that correspond to the <c>TextArea</c> filter control type.
        /// </para>
        /// </summary>
        public DefaultTextAreaControlOptions DefaultTextAreaOptions
        {
            get { return this._defaultTextAreaOptions; }
            set { this._defaultTextAreaOptions = value; }
        }

        // Check to see if DefaultTextAreaOptions property is set
        internal bool IsSetDefaultTextAreaOptions()
        {
            return this._defaultTextAreaOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultTextFieldOptions. 
        /// <para>
        /// The default options that correspond to the <c>TextField</c> filter control type.
        /// </para>
        /// </summary>
        public DefaultTextFieldControlOptions DefaultTextFieldOptions
        {
            get { return this._defaultTextFieldOptions; }
            set { this._defaultTextFieldOptions = value; }
        }

        // Check to see if DefaultTextFieldOptions property is set
        internal bool IsSetDefaultTextFieldOptions()
        {
            return this._defaultTextFieldOptions != null;
        }

    }
}