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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private string _ikeVersion;
        private int? _phase1DHGroup;
        private string _phase1EncryptionAlgorithm;
        private string _phase1IntegrityAlgorithm;
        private int? _phase2DHGroup;
        private string _phase2EncryptionAlgorithm;
        private string _phase2IntegrityAlgorithm;
        private VpnTunnelProvisioningStatus _provisioningStatus;
        private string _provisioningStatusReason;

        /// <summary>
        /// Gets and sets the property IkeVersion. 
        /// <para>
        /// The version of the Internet Key Exchange (IKE) protocol being used.
        /// </para>
        /// </summary>
        public string IkeVersion
        {
            get { return this._ikeVersion; }
            set { this._ikeVersion = value; }
        }

        // Check to see if IkeVersion property is set
        internal bool IsSetIkeVersion()
        {
            return this._ikeVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Phase1DHGroup. 
        /// <para>
        /// The Diffie-Hellman group number being used in Phase 1 IKE negotiations.
        /// </para>
        /// </summary>
        public int? Phase1DHGroup
        {
            get { return this._phase1DHGroup; }
            set { this._phase1DHGroup = value; }
        }

        // Check to see if Phase1DHGroup property is set
        internal bool IsSetPhase1DHGroup()
        {
            return this._phase1DHGroup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Phase1EncryptionAlgorithm. 
        /// <para>
        /// The encryption algorithm negotiated in Phase 1 IKE negotiations.
        /// </para>
        /// </summary>
        public string Phase1EncryptionAlgorithm
        {
            get { return this._phase1EncryptionAlgorithm; }
            set { this._phase1EncryptionAlgorithm = value; }
        }

        // Check to see if Phase1EncryptionAlgorithm property is set
        internal bool IsSetPhase1EncryptionAlgorithm()
        {
            return this._phase1EncryptionAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property Phase1IntegrityAlgorithm. 
        /// <para>
        /// The integrity algorithm negotiated in Phase 1 IKE negotiations.
        /// </para>
        /// </summary>
        public string Phase1IntegrityAlgorithm
        {
            get { return this._phase1IntegrityAlgorithm; }
            set { this._phase1IntegrityAlgorithm = value; }
        }

        // Check to see if Phase1IntegrityAlgorithm property is set
        internal bool IsSetPhase1IntegrityAlgorithm()
        {
            return this._phase1IntegrityAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property Phase2DHGroup. 
        /// <para>
        /// The Diffie-Hellman group number being used in Phase 2 IKE negotiations.
        /// </para>
        /// </summary>
        public int? Phase2DHGroup
        {
            get { return this._phase2DHGroup; }
            set { this._phase2DHGroup = value; }
        }

        // Check to see if Phase2DHGroup property is set
        internal bool IsSetPhase2DHGroup()
        {
            return this._phase2DHGroup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Phase2EncryptionAlgorithm. 
        /// <para>
        /// The encryption algorithm negotiated in Phase 2 IKE negotiations.
        /// </para>
        /// </summary>
        public string Phase2EncryptionAlgorithm
        {
            get { return this._phase2EncryptionAlgorithm; }
            set { this._phase2EncryptionAlgorithm = value; }
        }

        // Check to see if Phase2EncryptionAlgorithm property is set
        internal bool IsSetPhase2EncryptionAlgorithm()
        {
            return this._phase2EncryptionAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property Phase2IntegrityAlgorithm. 
        /// <para>
        /// The integrity algorithm negotiated in Phase 2 IKE negotiations.
        /// </para>
        /// </summary>
        public string Phase2IntegrityAlgorithm
        {
            get { return this._phase2IntegrityAlgorithm; }
            set { this._phase2IntegrityAlgorithm = value; }
        }

        // Check to see if Phase2IntegrityAlgorithm property is set
        internal bool IsSetPhase2IntegrityAlgorithm()
        {
            return this._phase2IntegrityAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningStatus. 
        /// <para>
        /// The current provisioning status of the VPN tunnel.
        /// </para>
        /// </summary>
        public VpnTunnelProvisioningStatus ProvisioningStatus
        {
            get { return this._provisioningStatus; }
            set { this._provisioningStatus = value; }
        }

        // Check to see if ProvisioningStatus property is set
        internal bool IsSetProvisioningStatus()
        {
            return this._provisioningStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningStatusReason. 
        /// <para>
        /// The reason for the current provisioning status.
        /// </para>
        /// </summary>
        public string ProvisioningStatusReason
        {
            get { return this._provisioningStatusReason; }
            set { this._provisioningStatusReason = value; }
        }

        // Check to see if ProvisioningStatusReason property is set
        internal bool IsSetProvisioningStatusReason()
        {
            return this._provisioningStatusReason != null;
        }

    }
}