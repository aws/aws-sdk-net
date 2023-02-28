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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// Information about the network impairment for a specific network measured by Amazon
    /// CloudWatch Internet Monitor.
    /// </summary>
    public partial class NetworkImpairment
    {
        private List<Network> _asPath = new List<Network>();
        private TriangulationEventType _networkEventType;
        private List<Network> _networks = new List<Network>();

        /// <summary>
        /// Gets and sets the property AsPath. 
        /// <para>
        /// The combination of the Autonomous System Number (ASN) of the network and the name
        /// of the network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Network> AsPath
        {
            get { return this._asPath; }
            set { this._asPath = value; }
        }

        // Check to see if AsPath property is set
        internal bool IsSetAsPath()
        {
            return this._asPath != null && this._asPath.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkEventType. 
        /// <para>
        /// Type of network impairment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TriangulationEventType NetworkEventType
        {
            get { return this._networkEventType; }
            set { this._networkEventType = value; }
        }

        // Check to see if NetworkEventType property is set
        internal bool IsSetNetworkEventType()
        {
            return this._networkEventType != null;
        }

        /// <summary>
        /// Gets and sets the property Networks. 
        /// <para>
        /// The networks that could be impacted by a network impairment event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Network> Networks
        {
            get { return this._networks; }
            set { this._networks = value; }
        }

        // Check to see if Networks property is set
        internal bool IsSetNetworks()
        {
            return this._networks != null && this._networks.Count > 0; 
        }

    }
}