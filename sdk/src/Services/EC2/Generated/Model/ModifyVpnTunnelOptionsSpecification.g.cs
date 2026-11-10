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
    /// The Amazon Web Services Site-to-Site VPN tunnel options to modify.
    /// </summary>
    public partial class ModifyVpnTunnelOptionsSpecification
    {
        /// <summary>
        /// Gets and sets the property DPDTimeoutAction. 
        /// <para>
        /// The action to take after DPD timeout occurs. Specify <c>restart</c> to restart the
        /// IKE initiation. Specify <c>clear</c> to end the IKE session.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>clear</c> | <c>none</c> | <c>restart</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>clear</c> 
        /// </para>
        /// </summary>
        public string DPDTimeoutAction { get; set; }

        /// <summary>
        /// Checks to see if the DPDTimeoutAction property is set.
        /// </summary>
        internal bool IsSetDPDTimeoutAction() => this.DPDTimeoutAction != null;

        /// <summary>
        /// Gets and sets the property DPDTimeoutSeconds. 
        /// <para>
        /// The number of seconds after which a DPD timeout occurs. A DPD timeout of 40 seconds
        /// means that the VPN endpoint will consider the peer dead 30 seconds after the first
        /// failed keep-alive.
        /// </para>
        ///  
        /// <para>
        /// Constraints: A value greater than or equal to 30.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>40</c> 
        /// </para>
        /// </summary>
        public int? DPDTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DPDTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetDPDTimeoutSeconds() => this.DPDTimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property EnableTunnelLifecycleControl. 
        /// <para>
        /// Turn on or off tunnel endpoint lifecycle control feature.
        /// </para>
        /// </summary>
        public bool? EnableTunnelLifecycleControl { get; set; }

        /// <summary>
        /// Checks to see if the EnableTunnelLifecycleControl property is set.
        /// </summary>
        internal bool IsSetEnableTunnelLifecycleControl() => this.EnableTunnelLifecycleControl.HasValue;

        /// <summary>
        /// Gets and sets the property IKEVersions. 
        /// <para>
        /// The IKE versions that are permitted for the VPN tunnel.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>ikev1</c> | <c>ikev2</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IKEVersionsRequestListValue> IKEVersions { get; set; } = AWSConfigs.InitializeCollections ? new List<IKEVersionsRequestListValue>() : null;

        /// <summary>
        /// Checks to see if the IKEVersions property is set.
        /// </summary>
        internal bool IsSetIKEVersions() => this.IKEVersions != null && (this.IKEVersions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogOptions. 
        /// <para>
        /// Options for logging VPN tunnel activity.
        /// </para>
        /// </summary>
        public VpnTunnelLogOptionsSpecification LogOptions { get; set; }

        /// <summary>
        /// Checks to see if the LogOptions property is set.
        /// </summary>
        internal bool IsSetLogOptions() => this.LogOptions != null;

        /// <summary>
        /// Gets and sets the property Phase1DHGroupNumbers. 
        /// <para>
        /// One or more Diffie-Hellman group numbers that are permitted for the VPN tunnel for
        /// phase 1 IKE negotiations.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>2</c> | <c>14</c> | <c>15</c> | <c>16</c> | <c>17</c> | <c>18</c>
        /// | <c>19</c> | <c>20</c> | <c>21</c> | <c>22</c> | <c>23</c> | <c>24</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Phase1DHGroupNumbersRequestListValue> Phase1DHGroupNumbers { get; set; } = AWSConfigs.InitializeCollections ? new List<Phase1DHGroupNumbersRequestListValue>() : null;

        /// <summary>
        /// Checks to see if the Phase1DHGroupNumbers property is set.
        /// </summary>
        internal bool IsSetPhase1DHGroupNumbers() => this.Phase1DHGroupNumbers != null && (this.Phase1DHGroupNumbers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Phase1EncryptionAlgorithms. 
        /// <para>
        /// One or more encryption algorithms that are permitted for the VPN tunnel for phase
        /// 1 IKE negotiations.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>AES128</c> | <c>AES256</c> | <c>AES128-GCM-16</c> | <c>AES256-GCM-16</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Phase1EncryptionAlgorithmsRequestListValue> Phase1EncryptionAlgorithms { get; set; } = AWSConfigs.InitializeCollections ? new List<Phase1EncryptionAlgorithmsRequestListValue>() : null;

        /// <summary>
        /// Checks to see if the Phase1EncryptionAlgorithms property is set.
        /// </summary>
        internal bool IsSetPhase1EncryptionAlgorithms() => this.Phase1EncryptionAlgorithms != null && (this.Phase1EncryptionAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Phase1IntegrityAlgorithms. 
        /// <para>
        /// One or more integrity algorithms that are permitted for the VPN tunnel for phase 1
        /// IKE negotiations.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>SHA1</c> | <c>SHA2-256</c> | <c>SHA2-384</c> | <c>SHA2-512</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Phase1IntegrityAlgorithmsRequestListValue> Phase1IntegrityAlgorithms { get; set; } = AWSConfigs.InitializeCollections ? new List<Phase1IntegrityAlgorithmsRequestListValue>() : null;

        /// <summary>
        /// Checks to see if the Phase1IntegrityAlgorithms property is set.
        /// </summary>
        internal bool IsSetPhase1IntegrityAlgorithms() => this.Phase1IntegrityAlgorithms != null && (this.Phase1IntegrityAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Phase1LifetimeSeconds. 
        /// <para>
        /// The lifetime for phase 1 of the IKE negotiation, in seconds.
        /// </para>
        ///  
        /// <para>
        /// Constraints: A value between 900 and 28,800.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>28800</c> 
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
        /// One or more Diffie-Hellman group numbers that are permitted for the VPN tunnel for
        /// phase 2 IKE negotiations.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>2</c> | <c>5</c> | <c>14</c> | <c>15</c> | <c>16</c> | <c>17</c>
        /// | <c>18</c> | <c>19</c> | <c>20</c> | <c>21</c> | <c>22</c> | <c>23</c> | <c>24</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Phase2DHGroupNumbersRequestListValue> Phase2DHGroupNumbers { get; set; } = AWSConfigs.InitializeCollections ? new List<Phase2DHGroupNumbersRequestListValue>() : null;

        /// <summary>
        /// Checks to see if the Phase2DHGroupNumbers property is set.
        /// </summary>
        internal bool IsSetPhase2DHGroupNumbers() => this.Phase2DHGroupNumbers != null && (this.Phase2DHGroupNumbers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Phase2EncryptionAlgorithms. 
        /// <para>
        /// One or more encryption algorithms that are permitted for the VPN tunnel for phase
        /// 2 IKE negotiations.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>AES128</c> | <c>AES256</c> | <c>AES128-GCM-16</c> | <c>AES256-GCM-16</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Phase2EncryptionAlgorithmsRequestListValue> Phase2EncryptionAlgorithms { get; set; } = AWSConfigs.InitializeCollections ? new List<Phase2EncryptionAlgorithmsRequestListValue>() : null;

        /// <summary>
        /// Checks to see if the Phase2EncryptionAlgorithms property is set.
        /// </summary>
        internal bool IsSetPhase2EncryptionAlgorithms() => this.Phase2EncryptionAlgorithms != null && (this.Phase2EncryptionAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Phase2IntegrityAlgorithms. 
        /// <para>
        /// One or more integrity algorithms that are permitted for the VPN tunnel for phase 2
        /// IKE negotiations.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>SHA1</c> | <c>SHA2-256</c> | <c>SHA2-384</c> | <c>SHA2-512</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Phase2IntegrityAlgorithmsRequestListValue> Phase2IntegrityAlgorithms { get; set; } = AWSConfigs.InitializeCollections ? new List<Phase2IntegrityAlgorithmsRequestListValue>() : null;

        /// <summary>
        /// Checks to see if the Phase2IntegrityAlgorithms property is set.
        /// </summary>
        internal bool IsSetPhase2IntegrityAlgorithms() => this.Phase2IntegrityAlgorithms != null && (this.Phase2IntegrityAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Phase2LifetimeSeconds. 
        /// <para>
        /// The lifetime for phase 2 of the IKE negotiation, in seconds.
        /// </para>
        ///  
        /// <para>
        /// Constraints: A value between 900 and 3,600. The value must be less than the value
        /// for <c>Phase1LifetimeSeconds</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>3600</c> 
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
        ///  
        /// <para>
        /// Constraints: Allowed characters are alphanumeric characters, periods (.), and underscores
        /// (_). Must be between 8 and 64 characters in length and cannot start with zero (0).
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
        /// The percentage of the rekey window (determined by <c>RekeyMarginTimeSeconds</c>) during
        /// which the rekey time is randomly selected.
        /// </para>
        ///  
        /// <para>
        /// Constraints: A value between 0 and 100.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>100</c> 
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
        /// Amazon Web Services side of the VPN connection performs an IKE rekey. The exact time
        /// of the rekey is randomly selected based on the value for <c>RekeyFuzzPercentage</c>.
        /// </para>
        ///  
        /// <para>
        /// Constraints: A value between 60 and half of <c>Phase2LifetimeSeconds</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>270</c> 
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
        ///  
        /// <para>
        /// Constraints: A value between 64 and 2048.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>1024</c> 
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
        /// The action to take when the establishing the tunnel for the VPN connection. By default,
        /// your customer gateway device must initiate the IKE negotiation and bring up the tunnel.
        /// Specify <c>start</c> for Amazon Web Services to initiate the IKE negotiation.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>add</c> | <c>start</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>add</c> 
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
        /// The range of inside IPv4 addresses for the tunnel. Any specified CIDR blocks must
        /// be unique across all VPN connections that use the same virtual private gateway. 
        /// </para>
        ///  
        /// <para>
        /// Constraints: A size /30 CIDR block from the <c>169.254.0.0/16</c> range. The following
        /// CIDR blocks are reserved and cannot be used:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>169.254.0.0/30</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>169.254.1.0/30</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>169.254.2.0/30</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>169.254.3.0/30</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>169.254.4.0/30</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>169.254.5.0/30</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>169.254.169.252/30</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string TunnelInsideCidr { get; set; }

        /// <summary>
        /// Checks to see if the TunnelInsideCidr property is set.
        /// </summary>
        internal bool IsSetTunnelInsideCidr() => this.TunnelInsideCidr != null;

        /// <summary>
        /// Gets and sets the property TunnelInsideIpv6Cidr. 
        /// <para>
        /// The range of inside IPv6 addresses for the tunnel. Any specified CIDR blocks must
        /// be unique across all VPN connections that use the same transit gateway.
        /// </para>
        ///  
        /// <para>
        /// Constraints: A size /126 CIDR block from the local <c>fd00::/8</c> range.
        /// </para>
        /// </summary>
        public string TunnelInsideIpv6Cidr { get; set; }

        /// <summary>
        /// Checks to see if the TunnelInsideIpv6Cidr property is set.
        /// </summary>
        internal bool IsSetTunnelInsideIpv6Cidr() => this.TunnelInsideIpv6Cidr != null;
    }
}
