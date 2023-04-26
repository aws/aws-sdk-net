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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The VPN tunnel options.
    /// </summary>
    public partial class TunnelOption
    {
        private string _dpdTimeoutAction;
        private int? _dpdTimeoutSeconds;
        private bool? _enableTunnelLifecycleControl;
        private List<IKEVersionsListValue> _ikeVersions = new List<IKEVersionsListValue>();
        private VpnTunnelLogOptions _logOptions;
        private string _outsideIpAddress;
        private List<Phase1DHGroupNumbersListValue> _phase1DHGroupNumbers = new List<Phase1DHGroupNumbersListValue>();
        private List<Phase1EncryptionAlgorithmsListValue> _phase1EncryptionAlgorithms = new List<Phase1EncryptionAlgorithmsListValue>();
        private List<Phase1IntegrityAlgorithmsListValue> _phase1IntegrityAlgorithms = new List<Phase1IntegrityAlgorithmsListValue>();
        private int? _phase1LifetimeSeconds;
        private List<Phase2DHGroupNumbersListValue> _phase2DHGroupNumbers = new List<Phase2DHGroupNumbersListValue>();
        private List<Phase2EncryptionAlgorithmsListValue> _phase2EncryptionAlgorithms = new List<Phase2EncryptionAlgorithmsListValue>();
        private List<Phase2IntegrityAlgorithmsListValue> _phase2IntegrityAlgorithms = new List<Phase2IntegrityAlgorithmsListValue>();
        private int? _phase2LifetimeSeconds;
        private string _preSharedKey;
        private int? _rekeyFuzzPercentage;
        private int? _rekeyMarginTimeSeconds;
        private int? _replayWindowSize;
        private string _startupAction;
        private string _tunnelInsideCidr;
        private string _tunnelInsideIpv6Cidr;

        /// <summary>
        /// Gets and sets the property DpdTimeoutAction. 
        /// <para>
        /// The action to take after a DPD timeout occurs.
        /// </para>
        /// </summary>
        public string DpdTimeoutAction
        {
            get { return this._dpdTimeoutAction; }
            set { this._dpdTimeoutAction = value; }
        }

        // Check to see if DpdTimeoutAction property is set
        internal bool IsSetDpdTimeoutAction()
        {
            return this._dpdTimeoutAction != null;
        }

        /// <summary>
        /// Gets and sets the property DpdTimeoutSeconds. 
        /// <para>
        /// The number of seconds after which a DPD timeout occurs.
        /// </para>
        /// </summary>
        public int DpdTimeoutSeconds
        {
            get { return this._dpdTimeoutSeconds.GetValueOrDefault(); }
            set { this._dpdTimeoutSeconds = value; }
        }

        // Check to see if DpdTimeoutSeconds property is set
        internal bool IsSetDpdTimeoutSeconds()
        {
            return this._dpdTimeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableTunnelLifecycleControl. 
        /// <para>
        /// Status of tunnel endpoint lifecycle control feature.
        /// </para>
        /// </summary>
        public bool EnableTunnelLifecycleControl
        {
            get { return this._enableTunnelLifecycleControl.GetValueOrDefault(); }
            set { this._enableTunnelLifecycleControl = value; }
        }

        // Check to see if EnableTunnelLifecycleControl property is set
        internal bool IsSetEnableTunnelLifecycleControl()
        {
            return this._enableTunnelLifecycleControl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IkeVersions. 
        /// <para>
        /// The IKE versions that are permitted for the VPN tunnel.
        /// </para>
        /// </summary>
        public List<IKEVersionsListValue> IkeVersions
        {
            get { return this._ikeVersions; }
            set { this._ikeVersions = value; }
        }

        // Check to see if IkeVersions property is set
        internal bool IsSetIkeVersions()
        {
            return this._ikeVersions != null && this._ikeVersions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LogOptions. 
        /// <para>
        /// Options for logging VPN tunnel activity.
        /// </para>
        /// </summary>
        public VpnTunnelLogOptions LogOptions
        {
            get { return this._logOptions; }
            set { this._logOptions = value; }
        }

        // Check to see if LogOptions property is set
        internal bool IsSetLogOptions()
        {
            return this._logOptions != null;
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
        /// Gets and sets the property Phase1DHGroupNumbers. 
        /// <para>
        /// The permitted Diffie-Hellman group numbers for the VPN tunnel for phase 1 IKE negotiations.
        /// </para>
        /// </summary>
        public List<Phase1DHGroupNumbersListValue> Phase1DHGroupNumbers
        {
            get { return this._phase1DHGroupNumbers; }
            set { this._phase1DHGroupNumbers = value; }
        }

        // Check to see if Phase1DHGroupNumbers property is set
        internal bool IsSetPhase1DHGroupNumbers()
        {
            return this._phase1DHGroupNumbers != null && this._phase1DHGroupNumbers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Phase1EncryptionAlgorithms. 
        /// <para>
        /// The permitted encryption algorithms for the VPN tunnel for phase 1 IKE negotiations.
        /// </para>
        /// </summary>
        public List<Phase1EncryptionAlgorithmsListValue> Phase1EncryptionAlgorithms
        {
            get { return this._phase1EncryptionAlgorithms; }
            set { this._phase1EncryptionAlgorithms = value; }
        }

        // Check to see if Phase1EncryptionAlgorithms property is set
        internal bool IsSetPhase1EncryptionAlgorithms()
        {
            return this._phase1EncryptionAlgorithms != null && this._phase1EncryptionAlgorithms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Phase1IntegrityAlgorithms. 
        /// <para>
        /// The permitted integrity algorithms for the VPN tunnel for phase 1 IKE negotiations.
        /// </para>
        /// </summary>
        public List<Phase1IntegrityAlgorithmsListValue> Phase1IntegrityAlgorithms
        {
            get { return this._phase1IntegrityAlgorithms; }
            set { this._phase1IntegrityAlgorithms = value; }
        }

        // Check to see if Phase1IntegrityAlgorithms property is set
        internal bool IsSetPhase1IntegrityAlgorithms()
        {
            return this._phase1IntegrityAlgorithms != null && this._phase1IntegrityAlgorithms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Phase1LifetimeSeconds. 
        /// <para>
        /// The lifetime for phase 1 of the IKE negotiation, in seconds.
        /// </para>
        /// </summary>
        public int Phase1LifetimeSeconds
        {
            get { return this._phase1LifetimeSeconds.GetValueOrDefault(); }
            set { this._phase1LifetimeSeconds = value; }
        }

        // Check to see if Phase1LifetimeSeconds property is set
        internal bool IsSetPhase1LifetimeSeconds()
        {
            return this._phase1LifetimeSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Phase2DHGroupNumbers. 
        /// <para>
        /// The permitted Diffie-Hellman group numbers for the VPN tunnel for phase 2 IKE negotiations.
        /// </para>
        /// </summary>
        public List<Phase2DHGroupNumbersListValue> Phase2DHGroupNumbers
        {
            get { return this._phase2DHGroupNumbers; }
            set { this._phase2DHGroupNumbers = value; }
        }

        // Check to see if Phase2DHGroupNumbers property is set
        internal bool IsSetPhase2DHGroupNumbers()
        {
            return this._phase2DHGroupNumbers != null && this._phase2DHGroupNumbers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Phase2EncryptionAlgorithms. 
        /// <para>
        /// The permitted encryption algorithms for the VPN tunnel for phase 2 IKE negotiations.
        /// </para>
        /// </summary>
        public List<Phase2EncryptionAlgorithmsListValue> Phase2EncryptionAlgorithms
        {
            get { return this._phase2EncryptionAlgorithms; }
            set { this._phase2EncryptionAlgorithms = value; }
        }

        // Check to see if Phase2EncryptionAlgorithms property is set
        internal bool IsSetPhase2EncryptionAlgorithms()
        {
            return this._phase2EncryptionAlgorithms != null && this._phase2EncryptionAlgorithms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Phase2IntegrityAlgorithms. 
        /// <para>
        /// The permitted integrity algorithms for the VPN tunnel for phase 2 IKE negotiations.
        /// </para>
        /// </summary>
        public List<Phase2IntegrityAlgorithmsListValue> Phase2IntegrityAlgorithms
        {
            get { return this._phase2IntegrityAlgorithms; }
            set { this._phase2IntegrityAlgorithms = value; }
        }

        // Check to see if Phase2IntegrityAlgorithms property is set
        internal bool IsSetPhase2IntegrityAlgorithms()
        {
            return this._phase2IntegrityAlgorithms != null && this._phase2IntegrityAlgorithms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Phase2LifetimeSeconds. 
        /// <para>
        /// The lifetime for phase 2 of the IKE negotiation, in seconds.
        /// </para>
        /// </summary>
        public int Phase2LifetimeSeconds
        {
            get { return this._phase2LifetimeSeconds.GetValueOrDefault(); }
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
        /// The pre-shared key (PSK) to establish initial authentication between the virtual private
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
        /// The percentage of the rekey window determined by <code>RekeyMarginTimeSeconds</code>
        /// during which the rekey time is randomly selected.
        /// </para>
        /// </summary>
        public int RekeyFuzzPercentage
        {
            get { return this._rekeyFuzzPercentage.GetValueOrDefault(); }
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
        public int RekeyMarginTimeSeconds
        {
            get { return this._rekeyMarginTimeSeconds.GetValueOrDefault(); }
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
        public int ReplayWindowSize
        {
            get { return this._replayWindowSize.GetValueOrDefault(); }
            set { this._replayWindowSize = value; }
        }

        // Check to see if ReplayWindowSize property is set
        internal bool IsSetReplayWindowSize()
        {
            return this._replayWindowSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartupAction. 
        /// <para>
        /// The action to take when the establishing the VPN tunnels for a VPN connection.
        /// </para>
        /// </summary>
        public string StartupAction
        {
            get { return this._startupAction; }
            set { this._startupAction = value; }
        }

        // Check to see if StartupAction property is set
        internal bool IsSetStartupAction()
        {
            return this._startupAction != null;
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

        /// <summary>
        /// Gets and sets the property TunnelInsideIpv6Cidr. 
        /// <para>
        /// The range of inside IPv6 addresses for the tunnel.
        /// </para>
        /// </summary>
        public string TunnelInsideIpv6Cidr
        {
            get { return this._tunnelInsideIpv6Cidr; }
            set { this._tunnelInsideIpv6Cidr = value; }
        }

        // Check to see if TunnelInsideIpv6Cidr property is set
        internal bool IsSetTunnelInsideIpv6Cidr()
        {
            return this._tunnelInsideIpv6Cidr != null;
        }

    }
}