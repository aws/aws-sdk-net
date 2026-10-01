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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about an endpoint and port where client devices can connect to
    /// an MQTT broker on a Greengrass core device.
    /// </summary>
    public partial class ConnectivityInfo
    {
        /// <summary>
        /// Gets and sets the property HostAddress. 
        /// <para>
        /// The IP address or DNS address where client devices can connect to an MQTT broker on
        /// the Greengrass core device.
        /// </para>
        /// </summary>
        public string HostAddress { get; set; }

        /// <summary>
        /// Checks to see if the HostAddress property is set.
        /// </summary>
        internal bool IsSetHostAddress() => this.HostAddress != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// An ID for the connectivity information.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Additional metadata to provide to client devices that connect to this core device.
        /// </para>
        /// </summary>
        public string Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property PortNumber. 
        /// <para>
        /// The port where the MQTT broker operates on the core device. This port is typically
        /// 8883, which is the default port for the MQTT broker component that runs on core devices.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? PortNumber { get; set; }

        /// <summary>
        /// Checks to see if the PortNumber property is set.
        /// </summary>
        internal bool IsSetPortNumber() => this.PortNumber.HasValue;
    }
}
