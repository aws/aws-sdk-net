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

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Contains information about a hardware security module (HSM) in an CloudHSM cluster.
    /// </summary>
    public partial class Hsm
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone that contains the HSM.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The identifier (ID) of the cluster that contains the HSM.
        /// </para>
        /// </summary>
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property EniId. 
        /// <para>
        /// The identifier (ID) of the HSM's elastic network interface (ENI).
        /// </para>
        /// </summary>
        public string EniId { get; set; }

        /// <summary>
        /// Checks to see if the EniId property is set.
        /// </summary>
        internal bool IsSetEniId() => this.EniId != null;

        /// <summary>
        /// Gets and sets the property EniIp. 
        /// <para>
        /// The IP address of the HSM's elastic network interface (ENI).
        /// </para>
        /// </summary>
        public string EniIp { get; set; }

        /// <summary>
        /// Checks to see if the EniIp property is set.
        /// </summary>
        internal bool IsSetEniIp() => this.EniIp != null;

        /// <summary>
        /// Gets and sets the property EniIpV6. 
        /// <para>
        /// The IPv6 address (if any) of the HSM's elastic network interface (ENI).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string EniIpV6 { get; set; }

        /// <summary>
        /// Checks to see if the EniIpV6 property is set.
        /// </summary>
        internal bool IsSetEniIpV6() => this.EniIpV6 != null;

        /// <summary>
        /// Gets and sets the property HsmId. 
        /// <para>
        /// The HSM's identifier (ID).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HsmId { get; set; }

        /// <summary>
        /// Checks to see if the HsmId property is set.
        /// </summary>
        internal bool IsSetHsmId() => this.HsmId != null;

        /// <summary>
        /// Gets and sets the property HsmType. 
        /// <para>
        /// The type of HSM.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string HsmType { get; set; }

        /// <summary>
        /// Checks to see if the HsmType property is set.
        /// </summary>
        internal bool IsSetHsmType() => this.HsmType != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The HSM's state.
        /// </para>
        /// </summary>
        public HsmState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateMessage. 
        /// <para>
        /// A description of the HSM's state.
        /// </para>
        /// </summary>
        public string StateMessage { get; set; }

        /// <summary>
        /// Checks to see if the StateMessage property is set.
        /// </summary>
        internal bool IsSetStateMessage() => this.StateMessage != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The subnet that contains the HSM's elastic network interface (ENI).
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;
    }
}
