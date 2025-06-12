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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// The attribute payload.
    /// </summary>
    public partial class AttributePayload
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private bool? _merge;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A JSON string containing up to three key-value pair in JSON format. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>{\"attributes\":{\"string1\":\"string2\"}}</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Merge. 
        /// <para>
        /// Specifies whether the list of attributes provided in the <c>AttributePayload</c> is
        /// merged with the attributes stored in the registry, instead of overwriting them.
        /// </para>
        ///  
        /// <para>
        /// To remove an attribute, call <c>UpdateThing</c> with an empty attribute value.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>merge</c> attribute is only valid when calling <c>UpdateThing</c> or <c>UpdateThingGroup</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? Merge
        {
            get { return this._merge; }
            set { this._merge = value; }
        }

        // Check to see if Merge property is set
        internal bool IsSetMerge()
        {
            return this._merge.HasValue; 
        }

    }
}