/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Describes the properties of a security policy that was specified. For more information
    /// about security policies, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/security-policies.html">Working
    /// with security policies</a>.
    /// </summary>
    public partial class DescribedSecurityPolicy
    {
        private bool? _fips;
        private string _securityPolicyName;
        private List<string> _sshCiphers = new List<string>();
        private List<string> _sshKexs = new List<string>();
        private List<string> _sshMacs = new List<string>();
        private List<string> _tlsCiphers = new List<string>();

        /// <summary>
        /// Gets and sets the property Fips. 
        /// <para>
        /// Specifies whether this policy enables Federal Information Processing Standards (FIPS).
        /// </para>
        /// </summary>
        public bool Fips
        {
            get { return this._fips.GetValueOrDefault(); }
            set { this._fips = value; }
        }

        // Check to see if Fips property is set
        internal bool IsSetFips()
        {
            return this._fips.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityPolicyName. 
        /// <para>
        /// Specifies the name of the security policy that is attached to the server.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=100)]
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
        /// Specifies the enabled Secure Shell (SSH) cipher encryption algorithms in the security
        /// policy that is attached to the server.
        /// </para>
        /// </summary>
        public List<string> SshCiphers
        {
            get { return this._sshCiphers; }
            set { this._sshCiphers = value; }
        }

        // Check to see if SshCiphers property is set
        internal bool IsSetSshCiphers()
        {
            return this._sshCiphers != null && this._sshCiphers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SshKexs. 
        /// <para>
        /// Specifies the enabled SSH key exchange (KEX) encryption algorithms in the security
        /// policy that is attached to the server.
        /// </para>
        /// </summary>
        public List<string> SshKexs
        {
            get { return this._sshKexs; }
            set { this._sshKexs = value; }
        }

        // Check to see if SshKexs property is set
        internal bool IsSetSshKexs()
        {
            return this._sshKexs != null && this._sshKexs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SshMacs. 
        /// <para>
        /// Specifies the enabled SSH message authentication code (MAC) encryption algorithms
        /// in the security policy that is attached to the server.
        /// </para>
        /// </summary>
        public List<string> SshMacs
        {
            get { return this._sshMacs; }
            set { this._sshMacs = value; }
        }

        // Check to see if SshMacs property is set
        internal bool IsSetSshMacs()
        {
            return this._sshMacs != null && this._sshMacs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TlsCiphers. 
        /// <para>
        /// Specifies the enabled Transport Layer Security (TLS) cipher encryption algorithms
        /// in the security policy that is attached to the server.
        /// </para>
        /// </summary>
        public List<string> TlsCiphers
        {
            get { return this._tlsCiphers; }
            set { this._tlsCiphers = value; }
        }

        // Check to see if TlsCiphers property is set
        internal bool IsSetTlsCiphers()
        {
            return this._tlsCiphers != null && this._tlsCiphers.Count > 0; 
        }

    }
}