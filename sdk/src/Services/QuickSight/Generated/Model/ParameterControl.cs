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
    /// The control of a parameter that users can interact with in a dashboard or an analysis.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class ParameterControl
    {
        private ParameterDateTimePickerControl _dateTimePicker;
        private ParameterDropDownControl _dropdown;
        private ParameterListControl _list;
        private ParameterSliderControl _slider;
        private ParameterTextAreaControl _textArea;
        private ParameterTextFieldControl _textField;

        /// <summary>
        /// Gets and sets the property DateTimePicker. 
        /// <para>
        /// A control from a date parameter that specifies date and time.
        /// </para>
        /// </summary>
        public ParameterDateTimePickerControl DateTimePicker
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
        public ParameterDropDownControl Dropdown
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
        /// A control to display a list with buttons or boxes that are used to select either a
        /// single value or multiple values.
        /// </para>
        /// </summary>
        public ParameterListControl List
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
        /// Gets and sets the property Slider. 
        /// <para>
        /// A control to display a horizontal toggle bar. This is used to change a value by sliding
        /// the toggle.
        /// </para>
        /// </summary>
        public ParameterSliderControl Slider
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
        public ParameterTextAreaControl TextArea
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
        public ParameterTextFieldControl TextField
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