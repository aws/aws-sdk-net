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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// The latest value of the property.
    /// </summary>
    public partial class PropertyLatestValue
    {
        private EntityPropertyReference _propertyReference;
        private DataValue _propertyValue;

        /// <summary>
        /// Gets and sets the property PropertyReference. 
        /// <para>
        /// An object that specifies information about a property.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EntityPropertyReference PropertyReference
        {
            get { return this._propertyReference; }
            set { this._propertyReference = value; }
        }

        // Check to see if PropertyReference property is set
        internal bool IsSetPropertyReference()
        {
            return this._propertyReference != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyValue. 
        /// <para>
        /// The value of the property.
        /// </para>
        /// </summary>
        public DataValue PropertyValue
        {
            get { return this._propertyValue; }
            set { this._propertyValue = value; }
        }

        // Check to see if PropertyValue property is set
        internal bool IsSetPropertyValue()
        {
            return this._propertyValue != null;
        }

    }
}