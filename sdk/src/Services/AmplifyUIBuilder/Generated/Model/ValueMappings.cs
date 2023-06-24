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
    /// Represents the data binding configuration for a value map.
    /// </summary>
    public partial class ValueMappings
    {
        private Dictionary<string, FormInputBindingPropertiesValue> _bindingProperties = new Dictionary<string, FormInputBindingPropertiesValue>();
        private List<ValueMapping> _values = new List<ValueMapping>();

        /// <summary>
        /// Gets and sets the property BindingProperties. 
        /// <para>
        /// The information to bind fields to data at runtime.
        /// </para>
        /// </summary>
        public Dictionary<string, FormInputBindingPropertiesValue> BindingProperties
        {
            get { return this._bindingProperties; }
            set { this._bindingProperties = value; }
        }

        // Check to see if BindingProperties property is set
        internal bool IsSetBindingProperties()
        {
            return this._bindingProperties != null && this._bindingProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The value and display value pairs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ValueMapping> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}