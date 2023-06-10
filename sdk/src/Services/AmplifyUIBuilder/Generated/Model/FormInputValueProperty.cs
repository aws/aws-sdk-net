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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes the configuration for an input field on a form. Use <code>FormInputValueProperty</code>
    /// to specify the values to render or bind by default.
    /// </summary>
    public partial class FormInputValueProperty
    {
        private FormInputValuePropertyBindingProperties _bindingProperties;
        private List<FormInputValueProperty> _concat = new List<FormInputValueProperty>();
        private string _value;

        /// <summary>
        /// Gets and sets the property BindingProperties. 
        /// <para>
        /// The information to bind fields to data at runtime.
        /// </para>
        /// </summary>
        public FormInputValuePropertyBindingProperties BindingProperties
        {
            get { return this._bindingProperties; }
            set { this._bindingProperties = value; }
        }

        // Check to see if BindingProperties property is set
        internal bool IsSetBindingProperties()
        {
            return this._bindingProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Concat. 
        /// <para>
        /// A list of form properties to concatenate to create the value to assign to this field
        /// property.
        /// </para>
        /// </summary>
        public List<FormInputValueProperty> Concat
        {
            get { return this._concat; }
            set { this._concat = value; }
        }

        // Check to see if Concat property is set
        internal bool IsSetConcat()
        {
            return this._concat != null && this._concat.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value to assign to the input field.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}