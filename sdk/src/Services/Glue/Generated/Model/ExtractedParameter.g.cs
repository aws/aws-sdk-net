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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Parameter extraction configuration that defines how to extract and map values from
    /// API responses to request parameters.
    /// </summary>
    public partial class ExtractedParameter
    {
        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value to use if the parameter cannot be extracted from the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The parameter key name that will be used in subsequent requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property PropertyLocation. 
        /// <para>
        /// Specifies where this extracted parameter should be placed in subsequent requests,
        /// such as in headers, query parameters, or request body.
        /// </para>
        /// </summary>
        public PropertyLocation PropertyLocation { get; set; }

        /// <summary>
        /// Checks to see if the PropertyLocation property is set.
        /// </summary>
        internal bool IsSetPropertyLocation() => this.PropertyLocation != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The JSON path or extraction mapping that defines how to extract the parameter value
        /// from API responses.
        /// </para>
        /// </summary>
        public ResponseExtractionMapping Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
