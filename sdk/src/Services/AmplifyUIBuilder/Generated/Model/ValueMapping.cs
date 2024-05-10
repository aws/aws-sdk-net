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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Associates a complex object with a display value. Use <c>ValueMapping</c> to store
    /// how to represent complex objects when they are displayed.
    /// </summary>
    public partial class ValueMapping
    {
        private FormInputValueProperty _displayValue;
        private FormInputValueProperty _value;

        /// <summary>
        /// Gets and sets the property DisplayValue. 
        /// <para>
        /// The value to display for the complex object.
        /// </para>
        /// </summary>
        public FormInputValueProperty DisplayValue
        {
            get { return this._displayValue; }
            set { this._displayValue = value; }
        }

        // Check to see if DisplayValue property is set
        internal bool IsSetDisplayValue()
        {
            return this._displayValue != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The complex object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FormInputValueProperty Value
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