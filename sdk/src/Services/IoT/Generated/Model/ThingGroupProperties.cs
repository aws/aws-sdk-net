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
    /// Thing group properties.
    /// </summary>
    public partial class ThingGroupProperties
    {
        private AttributePayload _attributePayload;
        private string _thingGroupDescription;

        /// <summary>
        /// Gets and sets the property AttributePayload. 
        /// <para>
        /// The thing group attributes in JSON format.
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
        /// Gets and sets the property ThingGroupDescription. 
        /// <para>
        /// The thing group description.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2028)]
        public string ThingGroupDescription
        {
            get { return this._thingGroupDescription; }
            set { this._thingGroupDescription = value; }
        }

        // Check to see if ThingGroupDescription property is set
        internal bool IsSetThingGroupDescription()
        {
            return this._thingGroupDescription != null;
        }

    }
}