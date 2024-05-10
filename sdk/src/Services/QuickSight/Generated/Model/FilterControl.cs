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
    /// The control of a filter that is used to interact with a dashboard or an analysis.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class FilterControl
    {
        private FilterCrossSheetControl _crossSheet;
        private FilterDateTimePickerControl _dateTimePicker;
        private FilterDropDownControl _dropdown;
        private FilterListControl _list;
        private FilterRelativeDateTimeControl _relativeDateTime;
        private FilterSliderControl _slider;
        private FilterTextAreaControl _textArea;
        private FilterTextFieldControl _textField;

        /// <summary>
        /// Gets and sets the property CrossSheet. 
        /// <para>
        /// A control from a filter that is scoped across more than one sheet. This represents
        /// your filter control on a sheet
        /// </para>
        /// </summary>
        public FilterCrossSheetControl CrossSheet
        {
            get { return this._crossSheet; }
            set { this._crossSheet = value; }
        }

        // Check to see if CrossSheet property is set
        internal bool IsSetCrossSheet()
        {
            return this._crossSheet != null;
        }

        /// <summary>
        /// Gets and sets the property DateTimePicker. 
        /// <para>
        /// A control from a date filter that is used to specify date and time.
        /// </para>
        /// </summary>
        public FilterDateTimePickerControl DateTimePicker
        {
            get { return this._dateTimePicker; }
            set { this._dateTimePicker = value; }
        }

        // Check to see if DateTimePicker property is set
        internal bool IsSetDateTimePicker()
        {
            return this._dateTimePicker != null;
        }

        /// <summary>
        /// Gets and sets the property Dropdown. 
        /// <para>
        /// A control to display a dropdown list with buttons that are used to select a single
        /// value.
        /// </para>
        /// </summary>
        public FilterDropDownControl Dropdown
        {
            get { return this._dropdown; }
            set { this._dropdown = value; }
        }

        // Check to see if Dropdown property is set
        internal bool IsSetDropdown()
        {
            return this._dropdown != null;
        }

        /// <summary>
        /// Gets and sets the property List. 
        /// <para>
        /// A control to display a list of buttons or boxes. This is used to select either a single
        /// value or multiple values.
        /// </para>
        /// </summary>
        public FilterListControl List
        {
            get { return this._list; }
            set { this._list = value; }
        }

        // Check to see if List property is set
        internal bool IsSetList()
        {
            return this._list != null;
        }

        /// <summary>
        /// Gets and sets the property RelativeDateTime. 
        /// <para>
        /// A control from a date filter that is used to specify the relative date.
        /// </para>
        /// </summary>
        public FilterRelativeDateTimeControl RelativeDateTime
        {
            get { return this._relativeDateTime; }
            set { this._relativeDateTime = value; }
        }

        // Check to see if RelativeDateTime property is set
        internal bool IsSetRelativeDateTime()
        {
            return this._relativeDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property Slider. 
        /// <para>
        /// A control to display a horizontal toggle bar. This is used to change a value by sliding
        /// the toggle.
        /// </para>
        /// </summary>
        public FilterSliderControl Slider
        {
            get { return this._slider; }
            set { this._slider = value; }
        }

        // Check to see if Slider property is set
        internal bool IsSetSlider()
        {
            return this._slider != null;
        }

        /// <summary>
        /// Gets and sets the property TextArea. 
        /// <para>
        /// A control to display a text box that is used to enter multiple entries.
        /// </para>
        /// </summary>
        public FilterTextAreaControl TextArea
        {
            get { return this._textArea; }
            set { this._textArea = value; }
        }

        // Check to see if TextArea property is set
        internal bool IsSetTextArea()
        {
            return this._textArea != null;
        }

        /// <summary>
        /// Gets and sets the property TextField. 
        /// <para>
        /// A control to display a text box that is used to enter a single entry.
        /// </para>
        /// </summary>
        public FilterTextFieldControl TextField
        {
            get { return this._textField; }
            set { this._textField = value; }
        }

        // Check to see if TextField property is set
        internal bool IsSetTextField()
        {
            return this._textField != null;
        }

    }
}