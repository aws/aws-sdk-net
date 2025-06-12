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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
        private bool? _fips;
        private List<string> _protocols = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _securityPolicyName;
        private List<string> _sshCiphers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _sshHostKeyAlgorithms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _sshKexs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _sshMacs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _tlsCiphers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SecurityPolicyResourceType _type;

        /// <summary>
        /// Gets and sets the property Fips. 
        /// <para>
        /// Specifies whether this policy enables Federal Information Processing Standards (FIPS).
        /// This parameter applies to both server and connector security policies.
        /// </para>
        /// </summary>
        public bool? Fips
        {
            get { return this._fips; }
            set { this._fips = value; }
        }

        // Check to see if Fips property is set
        internal bool IsSetFips()
        {
            return this._fips.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        /// Lists the file transfer protocols that the security policy applies to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> Protocols
        {
            get { return this._protocols; }
            set { this._protocols = value; }
        }

        // Check to see if Protocols property is set
        internal bool IsSetProtocols()
        {
            return this._protocols != null && (this._protocols.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecurityPolicyName. 
        /// <para>
        /// The text name of the specified security policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string SecurityPolicyName
        {
            get { return this._securityPolicyName; }
            set { this._securityPolicyName = value; }
        }

        // Check to see if SecurityPolicyName property is set
        internal bool IsSetSecurityPolicyName()
        {
            return this._securityPolicyName != null;
        }

        /// <summary>
        /// Gets and sets the property SshCiphers. 
        /// <para>
        /// Lists the enabled Secure Shell (SSH) cipher encryption algorithms in the security
        /// policy that is attached to the server or connector. This parameter applies to both
        /// server and connector security policies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SshCiphers
        {
            get { return this._sshCiphers; }
            set { this._sshCiphers = value; }
        }

        // Check to see if SshCiphers property is set
        internal bool IsSetSshCiphers()
        {
            return this._sshCiphers != null && (this._sshCiphers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SshHostKeyAlgorithms
        {
            get { return this._sshHostKeyAlgorithms; }
            set { this._sshHostKeyAlgorithms = value; }
        }

        // Check to see if SshHostKeyAlgorithms property is set
        internal bool IsSetSshHostKeyAlgorithms()
        {
            return this._sshHostKeyAlgorithms != null && (this._sshHostKeyAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SshKexs. 
        /// <para>
        /// Lists the enabled SSH key exchange (KEX) encryption algorithms in the security policy
        /// that is attached to the server or connector. This parameter applies to both server
        /// and connector security policies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SshKexs
        {
            get { return this._sshKexs; }
            set { this._sshKexs = value; }
        }

        // Check to see if SshKexs property is set
        internal bool IsSetSshKexs()
        {
            return this._sshKexs != null && (this._sshKexs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SshMacs. 
        /// <para>
        /// Lists the enabled SSH message authentication code (MAC) encryption algorithms in the
        /// security policy that is attached to the server or connector. This parameter applies
        /// to both server and connector security policies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SshMacs
        {
            get { return this._sshMacs; }
            set { this._sshMacs = value; }
        }

        // Check to see if SshMacs property is set
        internal bool IsSetSshMacs()
        {
            return this._sshMacs != null && (this._sshMacs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TlsCiphers
        {
            get { return this._tlsCiphers; }
            set { this._tlsCiphers = value; }
        }

        // Check to see if TlsCiphers property is set
        internal bool IsSetTlsCiphers()
        {
            return this._tlsCiphers != null && (this._tlsCiphers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The resource type to which the security policy applies, either server or connector.
        /// </para>
        /// </summary>
        public SecurityPolicyResourceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}