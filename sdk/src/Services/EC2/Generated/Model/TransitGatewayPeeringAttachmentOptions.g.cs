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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes dynamic routing for the transit gateway peering attachment.
    /// </summary>
    public partial class TransitGatewayPeeringAttachmentOptions
    {
        /// <summary>
        /// Gets and sets the property AccepterAllowMultipathResilience. 
        /// <para>
        /// Indicates whether the accepter allows multipath resilience for the transit gateway
        /// peering attachment.
        /// </para>
        /// </summary>
        public bool? AccepterAllowMultipathResilience { get; set; }

        /// <summary>
        /// Checks to see if the AccepterAllowMultipathResilience property is set.
        /// </summary>
        internal bool IsSetAccepterAllowMultipathResilience() => this.AccepterAllowMultipathResilience.HasValue;

        /// <summary>
        /// Gets and sets the property AccepterMultipathResilienceMode. 
        /// <para>
        /// The multipath resilience mode for the accepter. This value is present only when the
        /// accepter allows multipath resilience.
        /// </para>
        /// </summary>
        public TransitGatewayPeeringAttachmentMultipathResilienceMode AccepterMultipathResilienceMode { get; set; }

        /// <summary>
        /// Checks to see if the AccepterMultipathResilienceMode property is set.
        /// </summary>
        internal bool IsSetAccepterMultipathResilienceMode() => this.AccepterMultipathResilienceMode != null;

        /// <summary>
        /// Gets and sets the property DynamicRouting. 
        /// <para>
        /// Describes whether dynamic routing is enabled or disabled for the transit gateway peering
        /// attachment.
        /// </para>
        /// </summary>
        public DynamicRoutingValue DynamicRouting { get; set; }

        /// <summary>
        /// Checks to see if the DynamicRouting property is set.
        /// </summary>
        internal bool IsSetDynamicRouting() => this.DynamicRouting != null;

        /// <summary>
        /// Gets and sets the property MultipathResilienceStatus. 
        /// <para>
        /// The multipath resilience status of the transit gateway peering attachment. The possible
        /// values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>enabled</c> – Both the requester and the accepter allow multipath resilience.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending</c> – Either the requester or the accepter allows multipath resilience,
        /// but not both.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>disabled</c> – Neither the requester nor the accepter allows multipath resilience.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TransitGatewayPeeringAttachmentMultipathResilienceStatus MultipathResilienceStatus { get; set; }

        /// <summary>
        /// Checks to see if the MultipathResilienceStatus property is set.
        /// </summary>
        internal bool IsSetMultipathResilienceStatus() => this.MultipathResilienceStatus != null;

        /// <summary>
        /// Gets and sets the property RequesterAllowMultipathResilience. 
        /// <para>
        /// Indicates whether the requester allows multipath resilience for the transit gateway
        /// peering attachment.
        /// </para>
        /// </summary>
        public bool? RequesterAllowMultipathResilience { get; set; }

        /// <summary>
        /// Checks to see if the RequesterAllowMultipathResilience property is set.
        /// </summary>
        internal bool IsSetRequesterAllowMultipathResilience() => this.RequesterAllowMultipathResilience.HasValue;

        /// <summary>
        /// Gets and sets the property RequesterMultipathResilienceMode. 
        /// <para>
        /// The multipath resilience mode for the requester. This value is present only when the
        /// requester allows multipath resilience.
        /// </para>
        /// </summary>
        public TransitGatewayPeeringAttachmentMultipathResilienceMode RequesterMultipathResilienceMode { get; set; }

        /// <summary>
        /// Checks to see if the RequesterMultipathResilienceMode property is set.
        /// </summary>
        internal bool IsSetRequesterMultipathResilienceMode() => this.RequesterMultipathResilienceMode != null;
    }
}
