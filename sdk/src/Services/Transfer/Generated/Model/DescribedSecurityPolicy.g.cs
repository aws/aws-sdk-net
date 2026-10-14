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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Describes the properties of a security policy that you specify. For more information
    /// about security policies, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/security-policies.html">Working
    /// with security policies for servers</a> or <a href="https://docs.aws.amazon.com/transfer/latest/userguide/security-policies-connectors.html">Working
    /// with security policies for SFTP connectors</a>.
    /// </summary>
    public partial class DescribedSecurityPolicy
    {
        /// <summary>
        /// Gets and sets the property Fips. 
        /// <para>
        /// Specifies whether this policy enables Federal Information Processing Standards (FIPS).
        /// This parameter applies to both server and connector security policies.
        /// </para>
        /// </summary>
        public bool? Fips { get; set; }

        /// <summary>
        /// Checks to see if the Fips property is set.
        /// </summary>
        internal bool IsSetFips() => this.Fips.HasValue;

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        /// Lists the file transfer protocols that the security policy applies to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> Protocols { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Protocols property is set.
        /// </summary>
        internal bool IsSetProtocols() => this.Protocols != null && (this.Protocols.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecurityPolicyName. 
        /// <para>
        /// The text name of the specified security policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public string SecurityPolicyName { get; set; }

        /// <summary>
        /// Checks to see if the SecurityPolicyName property is set.
        /// </summary>
        internal bool IsSetSecurityPolicyName() => this.SecurityPolicyName != null;

        /// <summary>
        /// Gets and sets the property SshCiphers. 
        /// <para>
        /// Lists the enabled Secure Shell (SSH) cipher encryption algorithms in the security
        /// policy that is attached to the server or connector. This parameter applies to both
        /// server and connector security policies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SshCiphers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SshCiphers property is set.
        /// </summary>
        internal bool IsSetSshCiphers() => this.SshCiphers != null && (this.SshCiphers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SshHostKeyAlgorithms. 
        /// <para>
        /// Lists the host key algorithms for the security policy.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter only applies to security policies for connectors.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SshHostKeyAlgorithms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SshHostKeyAlgorithms property is set.
        /// </summary>
        internal bool IsSetSshHostKeyAlgorithms() => this.SshHostKeyAlgorithms != null && (this.SshHostKeyAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SshKexs. 
        /// <para>
        /// Lists the enabled SSH key exchange (KEX) encryption algorithms in the security policy
        /// that is attached to the server or connector. This parameter applies to both server
        /// and connector security policies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SshKexs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SshKexs property is set.
        /// </summary>
        internal bool IsSetSshKexs() => this.SshKexs != null && (this.SshKexs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SshMacs. 
        /// <para>
        /// Lists the enabled SSH message authentication code (MAC) encryption algorithms in the
        /// security policy that is attached to the server or connector. This parameter applies
        /// to both server and connector security policies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SshMacs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SshMacs property is set.
        /// </summary>
        internal bool IsSetSshMacs() => this.SshMacs != null && (this.SshMacs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TlsCiphers. 
        /// <para>
        /// Lists the enabled Transport Layer Security (TLS) cipher encryption algorithms in the
        /// security policy that is attached to the server.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter only applies to security policies for servers.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TlsCiphers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TlsCiphers property is set.
        /// </summary>
        internal bool IsSetTlsCiphers() => this.TlsCiphers != null && (this.TlsCiphers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The resource type to which the security policy applies, either server or connector.
        /// </para>
        /// </summary>
        public SecurityPolicyResourceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
