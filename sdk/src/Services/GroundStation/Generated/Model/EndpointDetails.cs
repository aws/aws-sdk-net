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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Information about the endpoint details.
    /// </summary>
    public partial class EndpointDetails
    {
        private AwsGroundStationAgentEndpoint _awsGroundStationAgentEndpoint;
        private DataflowEndpoint _endpoint;
        private SecurityDetails _securityDetails;

        /// <summary>
        /// Gets and sets the property AwsGroundStationAgentEndpoint. 
        /// <para>
        /// An agent endpoint.
        /// </para>
        /// </summary>
        public AwsGroundStationAgentEndpoint AwsGroundStationAgentEndpoint
        {
            get { return this._awsGroundStationAgentEndpoint; }
            set { this._awsGroundStationAgentEndpoint = value; }
        }

        // Check to see if AwsGroundStationAgentEndpoint property is set
        internal bool IsSetAwsGroundStationAgentEndpoint()
        {
            return this._awsGroundStationAgentEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// A dataflow endpoint.
        /// </para>
        /// </summary>
        public DataflowEndpoint Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityDetails. 
        /// <para>
        /// Endpoint security details including a list of subnets, a list of security groups and
        /// a role to connect streams to instances.
        /// </para>
        /// </summary>
        public SecurityDetails SecurityDetails
        {
            get { return this._securityDetails; }
            set { this._securityDetails = value; }
        }

        // Check to see if SecurityDetails property is set
        internal bool IsSetSecurityDetails()
        {
            return this._securityDetails != null;
        }

    }
}