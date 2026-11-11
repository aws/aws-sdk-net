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
    /// Contains information about the current security configuration of an active VPN tunnel.
    /// </summary>
    public partial class ActiveVpnTunnelStatus
    {
        /// <summary>
        /// Gets and sets the property IkeVersion. 
        /// <para>
        /// The version of the Internet Key Exchange (IKE) protocol being used.
        /// </para>
        /// </summary>
        public string IkeVersion { get; set; }

        /// <summary>
        /// Checks to see if the IkeVersion property is set.
        /// </summary>
        internal bool IsSetIkeVersion() => this.IkeVersion != null;

        /// <summary>
        /// Gets and sets the property Phase1DHGroup. 
        /// <para>
        /// The Diffie-Hellman group number being used in Phase 1 IKE negotiations.
        /// </para>
        /// </summary>
        public int? Phase1DHGroup { get; set; }

        /// <summary>
        /// Checks to see if the Phase1DHGroup property is set.
        /// </summary>
        internal bool IsSetPhase1DHGroup() => this.Phase1DHGroup.HasValue;

        /// <summary>
        /// Gets and sets the property Phase1EncryptionAlgorithm. 
        /// <para>
        /// The encryption algorithm negotiated in Phase 1 IKE negotiations.
        /// </para>
        /// </summary>
        public string Phase1EncryptionAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the Phase1EncryptionAlgorithm property is set.
        /// </summary>
        internal bool IsSetPhase1EncryptionAlgorithm() => this.Phase1EncryptionAlgorithm != null;

        /// <summary>
        /// Gets and sets the property Phase1IntegrityAlgorithm. 
        /// <para>
        /// The integrity algorithm negotiated in Phase 1 IKE negotiations.
        /// </para>
        /// </summary>
        public string Phase1IntegrityAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the Phase1IntegrityAlgorithm property is set.
        /// </summary>
        internal bool IsSetPhase1IntegrityAlgorithm() => this.Phase1IntegrityAlgorithm != null;

        /// <summary>
        /// Gets and sets the property Phase2DHGroup. 
        /// <para>
        /// The Diffie-Hellman group number being used in Phase 2 IKE negotiations.
        /// </para>
        /// </summary>
        public int? Phase2DHGroup { get; set; }

        /// <summary>
        /// Checks to see if the Phase2DHGroup property is set.
        /// </summary>
        internal bool IsSetPhase2DHGroup() => this.Phase2DHGroup.HasValue;

        /// <summary>
        /// Gets and sets the property Phase2EncryptionAlgorithm. 
        /// <para>
        /// The encryption algorithm negotiated in Phase 2 IKE negotiations.
        /// </para>
        /// </summary>
        public string Phase2EncryptionAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the Phase2EncryptionAlgorithm property is set.
        /// </summary>
        internal bool IsSetPhase2EncryptionAlgorithm() => this.Phase2EncryptionAlgorithm != null;

        /// <summary>
        /// Gets and sets the property Phase2IntegrityAlgorithm. 
        /// <para>
        /// The integrity algorithm negotiated in Phase 2 IKE negotiations.
        /// </para>
        /// </summary>
        public string Phase2IntegrityAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the Phase2IntegrityAlgorithm property is set.
        /// </summary>
        internal bool IsSetPhase2IntegrityAlgorithm() => this.Phase2IntegrityAlgorithm != null;

        /// <summary>
        /// Gets and sets the property ProvisioningStatus. 
        /// <para>
        /// The current provisioning status of the VPN tunnel.
        /// </para>
        /// </summary>
        public VpnTunnelProvisioningStatus ProvisioningStatus { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningStatus property is set.
        /// </summary>
        internal bool IsSetProvisioningStatus() => this.ProvisioningStatus != null;

        /// <summary>
        /// Gets and sets the property ProvisioningStatusReason. 
        /// <para>
        /// The reason for the current provisioning status.
        /// </para>
        /// </summary>
        public string ProvisioningStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningStatusReason property is set.
        /// </summary>
        internal bool IsSetProvisioningStatusReason() => this.ProvisioningStatusReason != null;
    }
}
