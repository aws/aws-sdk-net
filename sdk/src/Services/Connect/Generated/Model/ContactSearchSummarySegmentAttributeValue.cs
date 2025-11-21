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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// The value of a segment attribute. This is structured as a map with a single key-value
    /// pair. The key 'valueString' indicates that the attribute type is a string, and its
    /// corresponding value is the actual string value of the segment attribute.
    /// </summary>
    public partial class ContactSearchSummarySegmentAttributeValue
    {
        private Dictionary<string, SegmentAttributeValue> _valueMap = AWSConfigs.InitializeCollections ? new Dictionary<string, SegmentAttributeValue>() : null;
        private string _valueString;

        /// <summary>
        /// Gets and sets the property ValueMap. 
        /// <para>
        /// The key and value of a segment attribute.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, SegmentAttributeValue> ValueMap
        {
            get { return this._valueMap; }
            set { this._valueMap = value; }
        }

        // Check to see if ValueMap property is set
        internal bool IsSetValueMap()
        {
            return this._valueMap != null && (this._valueMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValueString. 
        /// <para>
        /// The value of a segment attribute represented as a string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ValueString
        {
            get { return this._valueString; }
            set { this._valueString = value; }
        }

        // Check to see if ValueString property is set
        internal bool IsSetValueString()
        {
            return this._valueString != null;
        }

    }
}