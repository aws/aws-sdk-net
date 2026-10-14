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

namespace Amazon.Evs.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateEipToVlan operation. Associates an Elastic
    /// IP address with a public HCX VLAN. This operation is only allowed for public HCX VLANs
    /// at this time.
    /// </summary>
    public partial class AssociateEipToVlanRequest : AmazonEvsRequest
    {
        /// <summary>
        /// Gets and sets the property AllocationId. 
        /// <para>
        /// The Elastic IP address allocation ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 9, Max = 26)]
        public string AllocationId { get; set; }

        /// <summary>
        /// Checks to see if the AllocationId property is set.
        /// </summary>
        internal bool IsSetAllocationId() => this.AllocationId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. <note> 
        /// <para>
        /// This parameter is not used in Amazon EVS currently. If you supply input for this parameter,
        /// it will have no effect.
        /// </para>
        ///  </note> 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the environment creation request. If you do not specify a client token, a randomly
        /// generated token is used for the request to ensure idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// A unique ID for the environment containing the VLAN that the Elastic IP address associates
        /// with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property VlanName. 
        /// <para>
        /// The name of the VLAN. <c>hcx</c> is the only accepted VLAN name at this time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string VlanName { get; set; }

        /// <summary>
        /// Checks to see if the VlanName property is set.
        /// </summary>
        internal bool IsSetVlanName() => this.VlanName != null;
    }
}
