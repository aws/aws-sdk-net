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
    /// The configuration to add user-defined properties to enrich MQTT 5 messages.
    /// </summary>
    public partial class Mqtt5Configuration
    {
        private List<PropagatingAttribute> _propagatingAttributes = AWSConfigs.InitializeCollections ? new List<PropagatingAttribute>() : null;

        /// <summary>
        /// Gets and sets the property PropagatingAttributes. 
        /// <para>
        /// An object that represents the propagating thing attributes and the connection attributes.
        /// </para>
        /// </summary>
        public List<PropagatingAttribute> PropagatingAttributes
        {
            get { return this._propagatingAttributes; }
            set { this._propagatingAttributes = value; }
        }

        // Check to see if PropagatingAttributes property is set
        internal bool IsSetPropagatingAttributes()
        {
            return this._propagatingAttributes != null && (this._propagatingAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}