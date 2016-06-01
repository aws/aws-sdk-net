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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Points to a remote domain with which you are setting up a trust relationship. Conditional
    /// forwarders are required in order to set up a trust relationship with another domain.
    /// </summary>
    public partial class ConditionalForwarder
    {
        private List<string> _dnsIpAddrs = new List<string>();
        private string _remoteDomainName;
        private ReplicationScope _replicationScope;

        /// <summary>
        /// Gets and sets the property DnsIpAddrs. 
        /// <para>
        /// The IP addresses of the remote DNS server associated with RemoteDomainName. This is
        /// the IP address of the DNS server that your conditional forwarder points to.
        /// </para>
        /// </summary>
        public List<string> DnsIpAddrs
        {
            get { return this._dnsIpAddrs; }
            set { this._dnsIpAddrs = value; }
        }

        // Check to see if DnsIpAddrs property is set
        internal bool IsSetDnsIpAddrs()
        {
            return this._dnsIpAddrs != null && this._dnsIpAddrs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RemoteDomainName. 
        /// <para>
        /// The fully qualified domain name (FQDN) of the remote domains pointed to by the conditional
        /// forwarder.
        /// </para>
        /// </summary>
        public string RemoteDomainName
        {
            get { return this._remoteDomainName; }
            set { this._remoteDomainName = value; }
        }

        // Check to see if RemoteDomainName property is set
        internal bool IsSetRemoteDomainName()
        {
            return this._remoteDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationScope. 
        /// <para>
        /// The replication scope of the conditional forwarder. The only allowed value is <code>Domain</code>,
        /// which will replicate the conditional forwarder to all of the domain controllers for
        /// your AWS directory.
        /// </para>
        /// </summary>
        public ReplicationScope ReplicationScope
        {
            get { return this._replicationScope; }
            set { this._replicationScope = value; }
        }

        // Check to see if ReplicationScope property is set
        internal bool IsSetReplicationScope()
        {
            return this._replicationScope != null;
        }

    }
}