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
    /// Container for the parameters to the CreateThing operation.
    /// Creates a thing record in the registry.
    /// </summary>
    public partial class CreateThingRequest : AmazonIoTRequest
    {
        private AttributePayload _attributePayload;
        private string _thingName;
        private string _thingTypeName;

        /// <summary>
        /// Gets and sets the property AttributePayload. 
        /// <para>
        /// The attribute payload, which consists of up to three name/value pairs in a JSON document.
        /// For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>{\"attributes\":{\"string1\":\"string2\"}}</code> 
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
        /// The name of the thing to create.
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

        /// <summary>
        /// Gets and sets the property ThingTypeName. 
        /// <para>
        /// The name of the thing type associated with the new thing.
        /// </para>
        /// </summary>
        public string ThingTypeName
        {
            get { return this._thingTypeName; }
            set { this._thingTypeName = value; }
        }

        // Check to see if ThingTypeName property is set
        internal bool IsSetThingTypeName()
        {
            return this._thingTypeName != null;
        }

    }
}