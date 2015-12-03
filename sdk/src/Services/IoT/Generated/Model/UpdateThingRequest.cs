/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateThing operation.
    /// Updates the data for a thing.
    /// </summary>
    public partial class UpdateThingRequest : AmazonIoTRequest
    {
        private AttributePayload _attributePayload;
        private string _thingName;

        /// <summary>
        /// Gets and sets the property AttributePayload. 
        /// <para>
        /// The attribute payload, a JSON string containing up to three key-value pairs.
        /// </para>
        ///  
        /// <para>
        /// For example: {\"attributes\":{\"string1\":\"string2\”}}
        /// </para>
        /// </summary>
        public AttributePayload AttributePayload
        {
            get { return this._attributePayload; }
            set { this._attributePayload = value; }
        }

        // Check to see if AttributePayload property is set
        internal bool IsSetAttributePayload()
        {
            return this._attributePayload != null;
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The thing name.
        /// </para>
        /// </summary>
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

    }
}