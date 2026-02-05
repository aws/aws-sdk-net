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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Parameter extraction configuration that defines how to extract and map values from
    /// API responses to request parameters.
    /// </summary>
    public partial class ExtractedParameter
    {
        private string _defaultValue;
        private string _key;
        private PropertyLocation _propertyLocation;
        private ResponseExtractionMapping _value;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value to use if the parameter cannot be extracted from the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The parameter key name that will be used in subsequent requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyLocation. 
        /// <para>
        /// Specifies where this extracted parameter should be placed in subsequent requests,
        /// such as in headers, query parameters, or request body.
        /// </para>
        /// </summary>
        public PropertyLocation PropertyLocation
        {
            get { return this._propertyLocation; }
            set { this._propertyLocation = value; }
        }

        // Check to see if PropertyLocation property is set
        internal bool IsSetPropertyLocation()
        {
            return this._propertyLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The JSON path or extraction mapping that defines how to extract the parameter value
        /// from API responses.
        /// </para>
        /// </summary>
        public ResponseExtractionMapping Value
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