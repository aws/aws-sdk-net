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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// The vehicle middleware defined as a type of network interface. Examples of vehicle
    /// middleware include <c>ROS2</c> and <c>SOME/IP</c>.
    /// </summary>
    public partial class VehicleMiddleware
    {
        private string _name;
        private VehicleMiddlewareProtocol _protocolName;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the vehicle middleware. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProtocolName. 
        /// <para>
        /// The protocol name of the vehicle middleware. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VehicleMiddlewareProtocol ProtocolName
        {
            get { return this._protocolName; }
            set { this._protocolName = value; }
        }

        // Check to see if ProtocolName property is set
        internal bool IsSetProtocolName()
        {
            return this._protocolName != null;
        }

    }
}