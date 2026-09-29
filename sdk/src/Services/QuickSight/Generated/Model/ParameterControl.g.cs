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
        /// <summary>
        /// Gets and sets the property DateTimePicker. 
        /// <para>
        /// A control from a date parameter that specifies date and time.
        /// </para>
        /// </summary>
        public ParameterDateTimePickerControl DateTimePicker { get; set; }

        /// <summary>
        /// Checks to see if the DateTimePicker property is set.
        /// </summary>
        internal bool IsSetDateTimePicker() => this.DateTimePicker != null;

        /// <summary>
        /// Gets and sets the property Dropdown. 
        /// <para>
        /// A control to display a dropdown list with buttons that are used to select a single
        /// value.
        /// </para>
        /// </summary>
        public ParameterDropDownControl Dropdown { get; set; }

        /// <summary>
        /// Checks to see if the Dropdown property is set.
        /// </summary>
        internal bool IsSetDropdown() => this.Dropdown != null;

        /// <summary>
        /// Gets and sets the property List. 
        /// <para>
        /// A control to display a list with buttons or boxes that are used to select either a
        /// single value or multiple values.
        /// </para>
        /// </summary>
        public ParameterListControl List { get; set; }

        /// <summary>
        /// Checks to see if the List property is set.
        /// </summary>
        internal bool IsSetList() => this.List != null;

        /// <summary>
        /// Gets and sets the property Slider. 
        /// <para>
        /// A control to display a horizontal toggle bar. This is used to change a value by sliding
        /// the toggle.
        /// </para>
        /// </summary>
        public ParameterSliderControl Slider { get; set; }

        /// <summary>
        /// Checks to see if the Slider property is set.
        /// </summary>
        internal bool IsSetSlider() => this.Slider != null;

        /// <summary>
        /// Gets and sets the property TextArea. 
        /// <para>
        /// A control to display a text box that is used to enter multiple entries.
        /// </para>
        /// </summary>
        public ParameterTextAreaControl TextArea { get; set; }

        /// <summary>
        /// Checks to see if the TextArea property is set.
        /// </summary>
        internal bool IsSetTextArea() => this.TextArea != null;

        /// <summary>
        /// Gets and sets the property TextField. 
        /// <para>
        /// A control to display a text box that is used to enter a single entry.
        /// </para>
        /// </summary>
        public ParameterTextFieldControl TextField { get; set; }

        /// <summary>
        /// Checks to see if the TextField property is set.
        /// </summary>
        internal bool IsSetTextField() => this.TextField != null;
    }
}
