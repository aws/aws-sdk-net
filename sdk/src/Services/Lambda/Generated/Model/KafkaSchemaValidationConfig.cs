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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Specific schema validation configuration settings that tell Lambda the message attributes
    /// you want to validate and filter using your schema registry.
    /// </summary>
    public partial class KafkaSchemaValidationConfig
    {
        private KafkaSchemaValidationAttribute _attribute;

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        ///  The attributes you want your schema registry to validate and filter for. If you selected
        /// <c>JSON</c> as the <c>EventRecordFormat</c>, Lambda also deserializes the selected
        /// message attributes. 
        /// </para>
        /// </summary>
        public KafkaSchemaValidationAttribute Attribute
        {
            get { return this._attribute; }
            set { this._attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this._attribute != null;
        }

    }
}