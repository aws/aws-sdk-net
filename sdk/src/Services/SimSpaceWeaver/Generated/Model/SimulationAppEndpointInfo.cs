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
 * Do not modify this file. This file is generated from the simspaceweaver-2022-10-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimSpaceWeaver.Model
{
    /// <summary>
    /// Information about the network endpoint that you can use to connect to your custom
    /// or service app.
    /// </summary>
    public partial class SimulationAppEndpointInfo
    {
        private string _address;
        private List<SimulationAppPortMapping> _ingressPortMappings = new List<SimulationAppPortMapping>();

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The IP address of the app. SimSpace Weaver dynamically assigns this IP address when
        /// the app starts.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property IngressPortMappings. 
        /// <para>
        /// The inbound TCP/UDP port numbers of the app. The combination of an IP address and
        /// a port number form a network endpoint.
        /// </para>
        /// </summary>
        public List<SimulationAppPortMapping> IngressPortMappings
        {
            get { return this._ingressPortMappings; }
            set { this._ingressPortMappings = value; }
        }

        // Check to see if IngressPortMappings property is set
        internal bool IsSetIngressPortMappings()
        {
            return this._ingressPortMappings != null && this._ingressPortMappings.Count > 0; 
        }

    }
}