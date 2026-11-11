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
    /// The VPN tunnel options.
    /// </summary>
    public partial class TunnelOption
    {
        /// <summary>
        /// Gets and sets the property DpdTimeoutAction. 
        /// <para>
        /// The action to take after a DPD timeout occurs.
        /// </para>
        /// </summary>
        public string DpdTimeoutAction { get; set; }

        /// <summary>
        /// Checks to see if the DpdTimeoutAction property is set.
        /// </summary>
        internal bool IsSetDpdTimeoutAction() => this.DpdTimeoutAction != null;

        /// <summary>
        /// Gets and sets the property DpdTimeoutSeconds. 
        /// <para>
        /// The number of seconds after which a DPD timeout occurs.
        /// </para>
        /// </summary>
        public int? DpdTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DpdTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetDpdTimeoutSeconds() => this.DpdTimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property EnableTunnelLifecycleControl. 
        /// <para>
        /// Status of tunnel endpoint lifecycle control feature.
        /// </para>
        /// </summary>
        public bool? EnableTunnelLifecycleControl { get; set; }

        /// <summary>
        /// Checks to see if the EnableTunnelLifecycleControl property is set.
        /// </summary>
        internal bool IsSetEnableTunnelLifecycleControl() => this.EnableTunnelLifecycleControl.HasValue;

        /// <summary>
        /// Gets and sets the property IkeVersions. 
        /// <para>
        /// The IKE versions that are permitted for the VPN tunnel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IKEVersionsListValue> IkeVersions { get; set; } = AWSConfigs.InitializeCollections ? new List<IKEVersionsListValue>() : null;

        /// <summary>
        /// Checks to see if the IkeVersions property is set.
        /// </summary>
        internal bool IsSetIkeVersions() => this.IkeVersions != null && (this.IkeVersions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogOptions. 
        /// <para>
        /// Options for logging VPN tunnel activity.
        /// </para>
        /// </summary>
        public VpnTunnelLogOptions LogOptions { get; set; }

        /// <summary>
        /// Checks to see if the LogOptions property is set.
        /// </summary>
        internal bool IsSetLogOptions() => this.LogOptions != null;

        /// <summary>
        /// Gets and sets the property OutsideIpAddress. 
        /// <para>
        /// The external IP address of the VPN tunnel.
        /// </para>
        /// </summary>
        public string OutsideIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the OutsideIpAddress property is set.
        /// </summary>
        internal bool IsSetOutsideIpAddress() => this.OutsideIpAddress != null;

        /// <summary>
        /// Gets and sets the property Phase1DHGroupNumbers. 
        /// <para>
        /// The permitted Diffie-Hellman group numbers for the VPN tunnel for phase 1 IKE negotiations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Phase1DHGroupNumbersListValue> Phase1DHGroupNumbers { get; set; } = AWSConfigs.InitializeCollections ? new List<Phase1DHGroupNumbersListValue>() : null;

        /// <summary>
        /// Checks to see if the Phase1DHGroupNumbers property is set.
        /// </summary>
        internal bool IsSetPhase1DHGroupNumbers() => this.Phase1DHGroupNumbers != null && (this.Phase1DHGroupNumbers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Phase1EncryptionAlgorithms. 
        /// <para>
        /// The permitted encryption algorithms for the VPN tunnel for phase 1 IKE negotiations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Phase1EncryptionAlgorithmsListValue> Phase1EncryptionAlgorithms { get; set; } = AWSConfigs.InitializeCollections ? new List<Phase1EncryptionAlgorithmsListValue>() : null;

        /// <summary>
        /// Checks to see if the Phase1EncryptionAlgorithms property is set.
        /// </summary>
        internal bool IsSetPhase1EncryptionAlgorithms() => this.Phase1EncryptionAlgorithms != null && (this.Phase1EncryptionAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Phase1IntegrityAlgorithms. 
        /// <para>
        /// The permitted integrity algorithms for the VPN tunnel for phase 1 IKE negotiations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Phase1IntegrityAlgorithmsListValue> Phase1IntegrityAlgorithms { get; set; } = AWSConfigs.InitializeCollections ? new List<Phase1IntegrityAlgorithmsListValue>() : null;

        /// <summary>
        /// Checks to see if the Phase1IntegrityAlgorithms property is set.
        /// </summary>
        internal bool IsSetPhase1IntegrityAlgorithms() => this.Phase1IntegrityAlgorithms != null && (this.Phase1IntegrityAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Phase1LifetimeSeconds. 
        /// <para>
        /// The lifetime for phase 1 of the IKE negotiation, in seconds.
        /// </para>
        /// </summary>
        public int? Phase1LifetimeSeconds { get; set; }

        /// <summary>
        /// Checks to see if the Phase1LifetimeSeconds property is set.
        /// </summary>
        internal bool IsSetPhase1LifetimeSeconds() => this.Phase1LifetimeSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Phase2DHGroupNumbers. 
        /// <para>
        /// The permitted Diffie-Hellman group numbers for the VPN tunnel for phase 2 IKE negotiations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Phase2DHGroupNumbersListValue> Phase2DHGroupNumbers { get; set; } = AWSConfigs.InitializeCollections ? new List<Phase2DHGroupNumbersListValue>() : null;

        /// <summary>
        /// Checks to see if the Phase2DHGroupNumbers property is set.
        /// </summary>
        internal bool IsSetPhase2DHGroupNumbers() => this.Phase2DHGroupNumbers != null && (this.Phase2DHGroupNumbers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Phase2EncryptionAlgorithms. 
        /// <para>
        /// The permitted encryption algorithms for the VPN tunnel for phase 2 IKE negotiations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Phase2EncryptionAlgorithmsListValue> Phase2EncryptionAlgorithms { get; set; } = AWSConfigs.InitializeCollections ? new List<Phase2EncryptionAlgorithmsListValue>() : null;

        /// <summary>
        /// Checks to see if the Phase2EncryptionAlgorithms property is set.
        /// </summary>
        internal bool IsSetPhase2EncryptionAlgorithms() => this.Phase2EncryptionAlgorithms != null && (this.Phase2EncryptionAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Phase2IntegrityAlgorithms. 
        /// <para>
        /// The permitted integrity algorithms for the VPN tunnel for phase 2 IKE negotiations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Phase2IntegrityAlgorithmsListValue> Phase2IntegrityAlgorithms { get; set; } = AWSConfigs.InitializeCollections ? new List<Phase2IntegrityAlgorithmsListValue>() : null;

        /// <summary>
        /// Checks to see if the Phase2IntegrityAlgorithms property is set.
        /// </summary>
        internal bool IsSetPhase2IntegrityAlgorithms() => this.Phase2IntegrityAlgorithms != null && (this.Phase2IntegrityAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Phase2LifetimeSeconds. 
        /// <para>
        /// The lifetime for phase 2 of the IKE negotiation, in seconds.
        /// </para>
        /// </summary>
        public int? Phase2LifetimeSeconds { get; set; }

        /// <summary>
        /// Checks to see if the Phase2LifetimeSeconds property is set.
        /// </summary>
        internal bool IsSetPhase2LifetimeSeconds() => this.Phase2LifetimeSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property PreSharedKey. 
        /// <para>
        /// The pre-shared key (PSK) to establish initial authentication between the virtual private
        /// gateway and the customer gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string PreSharedKey { get; set; }

        /// <summary>
        /// Checks to see if the PreSharedKey property is set.
        /// </summary>
        internal bool IsSetPreSharedKey() => this.PreSharedKey != null;

        /// <summary>
        /// Gets and sets the property RekeyFuzzPercentage. 
        /// <para>
        /// The percentage of the rekey window determined by <c>RekeyMarginTimeSeconds</c> during
        /// which the rekey time is randomly selected.
        /// </para>
        /// </summary>
        public int? RekeyFuzzPercentage { get; set; }

        /// <summary>
        /// Checks to see if the RekeyFuzzPercentage property is set.
        /// </summary>
        internal bool IsSetRekeyFuzzPercentage() => this.RekeyFuzzPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property RekeyMarginTimeSeconds. 
        /// <para>
        /// The margin time, in seconds, before the phase 2 lifetime expires, during which the
        /// Amazon Web Services side of the VPN connection performs an IKE rekey.
        /// </para>
        /// </summary>
        public int? RekeyMarginTimeSeconds { get; set; }

        /// <summary>
        /// Checks to see if the RekeyMarginTimeSeconds property is set.
        /// </summary>
        internal bool IsSetRekeyMarginTimeSeconds() => this.RekeyMarginTimeSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ReplayWindowSize. 
        /// <para>
        /// The number of packets in an IKE replay window.
        /// </para>
        /// </summary>
        public int? ReplayWindowSize { get; set; }

        /// <summary>
        /// Checks to see if the ReplayWindowSize property is set.
        /// </summary>
        internal bool IsSetReplayWindowSize() => this.ReplayWindowSize.HasValue;

        /// <summary>
        /// Gets and sets the property StartupAction. 
        /// <para>
        /// The action to take when the establishing the VPN tunnels for a VPN connection.
        /// </para>
        /// </summary>
        public string StartupAction { get; set; }

        /// <summary>
        /// Checks to see if the StartupAction property is set.
        /// </summary>
        internal bool IsSetStartupAction() => this.StartupAction != null;

        /// <summary>
        /// Gets and sets the property TunnelInsideCidr. 
        /// <para>
        /// The range of inside IPv4 addresses for the tunnel.
        /// </para>
        /// </summary>
        public string TunnelInsideCidr { get; set; }

        /// <summary>
        /// Checks to see if the TunnelInsideCidr property is set.
        /// </summary>
        internal bool IsSetTunnelInsideCidr() => this.TunnelInsideCidr != null;

        /// <summary>
        /// Gets and sets the property TunnelInsideIpv6Cidr. 
        /// <para>
        /// The range of inside IPv6 addresses for the tunnel.
        /// </para>
        /// </summary>
        public string TunnelInsideIpv6Cidr { get; set; }

        /// <summary>
        /// Checks to see if the TunnelInsideIpv6Cidr property is set.
        /// </summary>
        internal bool IsSetTunnelInsideIpv6Cidr() => this.TunnelInsideIpv6Cidr != null;
    }
}
