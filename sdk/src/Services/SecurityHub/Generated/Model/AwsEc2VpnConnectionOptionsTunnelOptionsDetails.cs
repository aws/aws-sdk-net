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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The VPN tunnel options.
    /// </summary>
    public partial class AwsEc2VpnConnectionOptionsTunnelOptionsDetails
    {
        private int? _dpdTimeoutSeconds;
        private List<string> _ikeVersions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _outsideIpAddress;
        private List<int> _phase1DhGroupNumbers = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<string> _phase1EncryptionAlgorithms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _phase1IntegrityAlgorithms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _phase1LifetimeSeconds;
        private List<int> _phase2DhGroupNumbers = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<string> _phase2EncryptionAlgorithms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _phase2IntegrityAlgorithms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _phase2LifetimeSeconds;
        private string _preSharedKey;
        private int? _rekeyFuzzPercentage;
        private int? _rekeyMarginTimeSeconds;
        private int? _replayWindowSize;
        private string _tunnelInsideCidr;

        /// <summary>
        /// Gets and sets the property DpdTimeoutSeconds. 
        /// <para>
        /// The number of seconds after which a Dead Peer Detection (DPD) timeout occurs.
        /// </para>
        /// </summary>
        public int? DpdTimeoutSeconds
        {
            get { return this._dpdTimeoutSeconds; }
            set { this._dpdTimeoutSeconds = value; }
        }

        // Check to see if DpdTimeoutSeconds property is set
        internal bool IsSetDpdTimeoutSeconds()
        {
            return this._dpdTimeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IkeVersions. 
        /// <para>
        /// The Internet Key Exchange (IKE) versions that are permitted for the VPN tunnel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IkeVersions
        {
            get { return this._ikeVersions; }
            set { this._ikeVersions = value; }
        }

        // Check to see if IkeVersions property is set
        internal bool IsSetIkeVersions()
        {
            return this._ikeVersions != null && (this._ikeVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OutsideIpAddress. 
        /// <para>
        /// The external IP address of the VPN tunnel.
        /// </para>
        /// </summary>
        public string OutsideIpAddress
        {
            get { return this._outsideIpAddress; }
            set { this._outsideIpAddress = value; }
        }

        // Check to see if OutsideIpAddress property is set
        internal bool IsSetOutsideIpAddress()
        {
            return this._outsideIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Phase1DhGroupNumbers. 
        /// <para>
        /// The permitted Diffie-Hellman group numbers for the VPN tunnel for phase 1 IKE negotiations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Phase1DhGroupNumbers
        {
            get { return this._phase1DhGroupNumbers; }
            set { this._phase1DhGroupNumbers = value; }
        }

        // Check to see if Phase1DhGroupNumbers property is set
        internal bool IsSetPhase1DhGroupNumbers()
        {
            return this._phase1DhGroupNumbers != null && (this._phase1DhGroupNumbers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Phase1EncryptionAlgorithms. 
        /// <para>
        /// The permitted encryption algorithms for the VPN tunnel for phase 1 IKE negotiations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Phase1EncryptionAlgorithms
        {
            get { return this._phase1EncryptionAlgorithms; }
            set { this._phase1EncryptionAlgorithms = value; }
        }

        // Check to see if Phase1EncryptionAlgorithms property is set
        internal bool IsSetPhase1EncryptionAlgorithms()
        {
            return this._phase1EncryptionAlgorithms != null && (this._phase1EncryptionAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Phase1IntegrityAlgorithms. 
        /// <para>
        /// The permitted integrity algorithms for the VPN tunnel for phase 1 IKE negotiations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Phase1IntegrityAlgorithms
        {
            get { return this._phase1IntegrityAlgorithms; }
            set { this._phase1IntegrityAlgorithms = value; }
        }

        // Check to see if Phase1IntegrityAlgorithms property is set
        internal bool IsSetPhase1IntegrityAlgorithms()
        {
            return this._phase1IntegrityAlgorithms != null && (this._phase1IntegrityAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Phase1LifetimeSeconds. 
        /// <para>
        /// The lifetime for phase 1 of the IKE negotiation, in seconds.
        /// </para>
        /// </summary>
        public int? Phase1LifetimeSeconds
        {
            get { return this._phase1LifetimeSeconds; }
            set { this._phase1LifetimeSeconds = value; }
        }

        // Check to see if Phase1LifetimeSeconds property is set
        internal bool IsSetPhase1LifetimeSeconds()
        {
            return this._phase1LifetimeSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Phase2DhGroupNumbers. 
        /// <para>
        /// The permitted Diffie-Hellman group numbers for the VPN tunnel for phase 2 IKE negotiations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Phase2DhGroupNumbers
        {
            get { return this._phase2DhGroupNumbers; }
            set { this._phase2DhGroupNumbers = value; }
        }

        // Check to see if Phase2DhGroupNumbers property is set
        internal bool IsSetPhase2DhGroupNumbers()
        {
            return this._phase2DhGroupNumbers != null && (this._phase2DhGroupNumbers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Phase2EncryptionAlgorithms. 
        /// <para>
        /// The permitted encryption algorithms for the VPN tunnel for phase 2 IKE negotiations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Phase2EncryptionAlgorithms
        {
            get { return this._phase2EncryptionAlgorithms; }
            set { this._phase2EncryptionAlgorithms = value; }
        }

        // Check to see if Phase2EncryptionAlgorithms property is set
        internal bool IsSetPhase2EncryptionAlgorithms()
        {
            return this._phase2EncryptionAlgorithms != null && (this._phase2EncryptionAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Phase2IntegrityAlgorithms. 
        /// <para>
        /// The permitted integrity algorithms for the VPN tunnel for phase 2 IKE negotiations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Phase2IntegrityAlgorithms
        {
            get { return this._phase2IntegrityAlgorithms; }
            set { this._phase2IntegrityAlgorithms = value; }
        }

        // Check to see if Phase2IntegrityAlgorithms property is set
        internal bool IsSetPhase2IntegrityAlgorithms()
        {
            return this._phase2IntegrityAlgorithms != null && (this._phase2IntegrityAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Phase2LifetimeSeconds. 
        /// <para>
        /// The lifetime for phase 2 of the IKE negotiation, in seconds.
        /// </para>
        /// </summary>
        public int? Phase2LifetimeSeconds
        {
            get { return this._phase2LifetimeSeconds; }
            set { this._phase2LifetimeSeconds = value; }
        }

        // Check to see if Phase2LifetimeSeconds property is set
        internal bool IsSetPhase2LifetimeSeconds()
        {
            return this._phase2LifetimeSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreSharedKey. 
        /// <para>
        /// The preshared key to establish initial authentication between the virtual private
        /// gateway and the customer gateway.
        /// </para>
        /// </summary>
        public string PreSharedKey
        {
            get { return this._preSharedKey; }
            set { this._preSharedKey = value; }
        }

        // Check to see if PreSharedKey property is set
        internal bool IsSetPreSharedKey()
        {
            return this._preSharedKey != null;
        }

        /// <summary>
        /// Gets and sets the property RekeyFuzzPercentage. 
        /// <para>
        /// The percentage of the rekey window, which is determined by <c>RekeyMarginTimeSeconds</c>
        /// during which the rekey time is randomly selected.
        /// </para>
        /// </summary>
        public int? RekeyFuzzPercentage
        {
            get { return this._rekeyFuzzPercentage; }
            set { this._rekeyFuzzPercentage = value; }
        }

        // Check to see if RekeyFuzzPercentage property is set
        internal bool IsSetRekeyFuzzPercentage()
        {
            return this._rekeyFuzzPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RekeyMarginTimeSeconds. 
        /// <para>
        /// The margin time, in seconds, before the phase 2 lifetime expires, during which the
        /// Amazon Web Services side of the VPN connection performs an IKE rekey.
        /// </para>
        /// </summary>
        public int? RekeyMarginTimeSeconds
        {
            get { return this._rekeyMarginTimeSeconds; }
            set { this._rekeyMarginTimeSeconds = value; }
        }

        // Check to see if RekeyMarginTimeSeconds property is set
        internal bool IsSetRekeyMarginTimeSeconds()
        {
            return this._rekeyMarginTimeSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplayWindowSize. 
        /// <para>
        /// The number of packets in an IKE replay window.
        /// </para>
        /// </summary>
        public int? ReplayWindowSize
        {
            get { return this._replayWindowSize; }
            set { this._replayWindowSize = value; }
        }

        // Check to see if ReplayWindowSize property is set
        internal bool IsSetReplayWindowSize()
        {
            return this._replayWindowSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TunnelInsideCidr. 
        /// <para>
        /// The range of inside IPv4 addresses for the tunnel.
        /// </para>
        /// </summary>
        public string TunnelInsideCidr
        {
            get { return this._tunnelInsideCidr; }
            set { this._tunnelInsideCidr = value; }
        }

        // Check to see if TunnelInsideCidr property is set
        internal bool IsSetTunnelInsideCidr()
        {
            return this._tunnelInsideCidr != null;
        }

    }
}