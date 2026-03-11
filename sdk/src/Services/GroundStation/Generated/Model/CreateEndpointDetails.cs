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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Endpoint definition used for creating a dataflow endpoint
    /// </summary>
    public partial class CreateEndpointDetails
    {
        private DownlinkAwsGroundStationAgentEndpoint _downlinkAwsGroundStationAgentEndpoint;
        private UplinkAwsGroundStationAgentEndpoint _uplinkAwsGroundStationAgentEndpoint;

        /// <summary>
        /// Gets and sets the property DownlinkAwsGroundStationAgentEndpoint. 
        /// <para>
        /// Definition for a downlink agent endpoint
        /// </para>
        /// </summary>
        public DownlinkAwsGroundStationAgentEndpoint DownlinkAwsGroundStationAgentEndpoint
        {
            get { return this._downlinkAwsGroundStationAgentEndpoint; }
            set { this._downlinkAwsGroundStationAgentEndpoint = value; }
        }

        // Check to see if DownlinkAwsGroundStationAgentEndpoint property is set
        internal bool IsSetDownlinkAwsGroundStationAgentEndpoint()
        {
            return this._downlinkAwsGroundStationAgentEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property UplinkAwsGroundStationAgentEndpoint. 
        /// <para>
        /// Definition for an uplink agent endpoint
        /// </para>
        /// </summary>
        public UplinkAwsGroundStationAgentEndpoint UplinkAwsGroundStationAgentEndpoint
        {
            get { return this._uplinkAwsGroundStationAgentEndpoint; }
            set { this._uplinkAwsGroundStationAgentEndpoint = value; }
        }

        // Check to see if UplinkAwsGroundStationAgentEndpoint property is set
        internal bool IsSetUplinkAwsGroundStationAgentEndpoint()
        {
            return this._uplinkAwsGroundStationAgentEndpoint != null;
        }

    }
}