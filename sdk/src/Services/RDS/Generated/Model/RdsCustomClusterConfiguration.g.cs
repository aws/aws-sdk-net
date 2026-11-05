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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Reserved for future use.
    /// </summary>
    public partial class RdsCustomClusterConfiguration
    {
        /// <summary>
        /// Gets and sets the property InterconnectSubnetId. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public string InterconnectSubnetId { get; set; }

        /// <summary>
        /// Checks to see if the InterconnectSubnetId property is set.
        /// </summary>
        internal bool IsSetInterconnectSubnetId() => this.InterconnectSubnetId != null;

        /// <summary>
        /// Gets and sets the property ReplicaMode. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public ReplicaMode ReplicaMode { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaMode property is set.
        /// </summary>
        internal bool IsSetReplicaMode() => this.ReplicaMode != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayMulticastDomainId. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public string TransitGatewayMulticastDomainId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayMulticastDomainId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayMulticastDomainId() => this.TransitGatewayMulticastDomainId != null;
    }
}
