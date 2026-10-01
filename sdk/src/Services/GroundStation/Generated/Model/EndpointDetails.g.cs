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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Information about the endpoint details.
    /// </summary>
    public partial class EndpointDetails
    {
        /// <summary>
        /// Gets and sets the property AwsGroundStationAgentEndpoint. 
        /// <para>
        /// An agent endpoint.
        /// </para>
        /// </summary>
        public AwsGroundStationAgentEndpoint AwsGroundStationAgentEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the AwsGroundStationAgentEndpoint property is set.
        /// </summary>
        internal bool IsSetAwsGroundStationAgentEndpoint() => this.AwsGroundStationAgentEndpoint != null;

        /// <summary>
        /// Gets and sets the property DownlinkAwsGroundStationAgentEndpoint. 
        /// <para>
        /// Definition for a downlink agent endpoint
        /// </para>
        /// </summary>
        public DownlinkAwsGroundStationAgentEndpointDetails DownlinkAwsGroundStationAgentEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the DownlinkAwsGroundStationAgentEndpoint property is set.
        /// </summary>
        internal bool IsSetDownlinkAwsGroundStationAgentEndpoint() => this.DownlinkAwsGroundStationAgentEndpoint != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// A dataflow endpoint.
        /// </para>
        /// </summary>
        public DataflowEndpoint Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property HealthReasons. 
        /// <para>
        /// Health reasons for a dataflow endpoint. This field is ignored when calling <c>CreateDataflowEndpointGroup</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public List<string> HealthReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the HealthReasons property is set.
        /// </summary>
        internal bool IsSetHealthReasons() => this.HealthReasons != null && (this.HealthReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// A dataflow endpoint health status. This field is ignored when calling <c>CreateDataflowEndpointGroup</c>.
        /// </para>
        /// </summary>
        public CapabilityHealth HealthStatus { get; set; }

        /// <summary>
        /// Checks to see if the HealthStatus property is set.
        /// </summary>
        internal bool IsSetHealthStatus() => this.HealthStatus != null;

        /// <summary>
        /// Gets and sets the property SecurityDetails. 
        /// <para>
        /// Endpoint security details including a list of subnets, a list of security groups and
        /// a role to connect streams to instances.
        /// </para>
        /// </summary>
        public SecurityDetails SecurityDetails { get; set; }

        /// <summary>
        /// Checks to see if the SecurityDetails property is set.
        /// </summary>
        internal bool IsSetSecurityDetails() => this.SecurityDetails != null;

        /// <summary>
        /// Gets and sets the property UplinkAwsGroundStationAgentEndpoint. 
        /// <para>
        /// Definition for an uplink agent endpoint
        /// </para>
        /// </summary>
        public UplinkAwsGroundStationAgentEndpointDetails UplinkAwsGroundStationAgentEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the UplinkAwsGroundStationAgentEndpoint property is set.
        /// </summary>
        internal bool IsSetUplinkAwsGroundStationAgentEndpoint() => this.UplinkAwsGroundStationAgentEndpoint != null;
    }
}
