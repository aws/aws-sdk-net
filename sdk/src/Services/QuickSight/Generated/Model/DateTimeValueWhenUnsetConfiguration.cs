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
    /// The configuration that defines the default value of a <code>DateTime</code> parameter
    /// when a value has not been set.
    /// </summary>
    public partial class DateTimeValueWhenUnsetConfiguration
    {
        private DateTime? _customValue;
        private ValueWhenUnsetOption _valueWhenUnsetOption;

        /// <summary>
        /// Gets and sets the property CustomValue. 
        /// <para>
        /// A custom value that's used when the value of a parameter isn't set.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public DateTime CustomValue
        {
            get { return this._customValue.GetValueOrDefault(); }
            set { this._customValue = value; }
        }

        // Check to see if CustomValue property is set
        internal bool IsSetCustomValue()
        {
            return this._customValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValueWhenUnsetOption. 
        /// <para>
        /// The built-in options for default values. The value can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RECOMMENDED</code>: The recommended value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NULL</code>: The <code>NULL</code> value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ValueWhenUnsetOption ValueWhenUnsetOption
        {
            get { return this._valueWhenUnsetOption; }
            set { this._valueWhenUnsetOption = value; }
        }

        // Check to see if ValueWhenUnsetOption property is set
        internal bool IsSetValueWhenUnsetOption()
        {
            return this._valueWhenUnsetOption != null;
        }

    }
}