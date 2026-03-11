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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
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
namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// The NAT Gateway configuration used for recommendations.
    /// </summary>
    public partial class NatGatewayConfiguration
    {
        private long? _activeConnectionCount;
        private long? _packetsInFromDestination;
        private long? _packetsInFromSource;

        /// <summary>
        /// Gets and sets the property ActiveConnectionCount. 
        /// <para>
        /// The number of active connections through the NAT Gateway.
        /// </para>
        /// </summary>
        public long? ActiveConnectionCount
        {
            get { return this._activeConnectionCount; }
            set { this._activeConnectionCount = value; }
        }

        // Check to see if ActiveConnectionCount property is set
        internal bool IsSetActiveConnectionCount()
        {
            return this._activeConnectionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PacketsInFromDestination. 
        /// <para>
        /// The number of packets received from the destination through the NAT Gateway.
        /// </para>
        /// </summary>
        public long? PacketsInFromDestination
        {
            get { return this._packetsInFromDestination; }
            set { this._packetsInFromDestination = value; }
        }

        // Check to see if PacketsInFromDestination property is set
        internal bool IsSetPacketsInFromDestination()
        {
            return this._packetsInFromDestination.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PacketsInFromSource. 
        /// <para>
        /// The number of packets received from the source through the NAT Gateway.
        /// </para>
        /// </summary>
        public long? PacketsInFromSource
        {
            get { return this._packetsInFromSource; }
            set { this._packetsInFromSource = value; }
        }

        // Check to see if PacketsInFromSource property is set
        internal bool IsSetPacketsInFromSource()
        {
            return this._packetsInFromSource.HasValue; 
        }

    }
}