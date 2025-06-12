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
 * Do not modify this file. This file is generated from the iotsecuretunneling-2018-10-05.normal.json service model.
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
namespace Amazon.IoTSecureTunneling.Model
{
    /// <summary>
    /// The destination configuration.
    /// </summary>
    public partial class DestinationConfig
    {
        private List<string> _services = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _thingName;

        /// <summary>
        /// Gets and sets the property Services. 
        /// <para>
        /// A list of service names that identify the target application. The IoT client running
        /// on the destination device reads this value and uses it to look up a port or an IP
        /// address and a port. The IoT client instantiates the local proxy, which uses this information
        /// to connect to the destination application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> Services
        {
            get { return this._services; }
            set { this._services = value; }
        }

        // Check to see if Services property is set
        internal bool IsSetServices()
        {
            return this._services != null && (this._services.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the IoT thing to which you want to connect.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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