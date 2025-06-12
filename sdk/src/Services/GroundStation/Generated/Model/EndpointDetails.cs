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
    /// Information about the endpoint details.
    /// </summary>
    public partial class EndpointDetails
    {
        private AwsGroundStationAgentEndpoint _awsGroundStationAgentEndpoint;
        private DataflowEndpoint _endpoint;
        private List<string> _healthReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CapabilityHealth _healthStatus;
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
        /// Gets and sets the property HealthReasons. 
        /// <para>
        /// Health reasons for a dataflow endpoint. This field is ignored when calling <c>CreateDataflowEndpointGroup</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public List<string> HealthReasons
        {
            get { return this._healthReasons; }
            set { this._healthReasons = value; }
        }

        // Check to see if HealthReasons property is set
        internal bool IsSetHealthReasons()
        {
            return this._healthReasons != null && (this._healthReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// A dataflow endpoint health status. This field is ignored when calling <c>CreateDataflowEndpointGroup</c>.
        /// </para>
        /// </summary>
        public CapabilityHealth HealthStatus
        {
            get { return this._healthStatus; }
            set { this._healthStatus = value; }
        }

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this._healthStatus != null;
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