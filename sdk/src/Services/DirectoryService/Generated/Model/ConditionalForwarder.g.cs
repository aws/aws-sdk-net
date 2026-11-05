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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Points to a remote domain with which you are setting up a trust relationship. Conditional
    /// forwarders are required in order to set up a trust relationship with another domain.
    /// </summary>
    public partial class ConditionalForwarder
    {
        /// <summary>
        /// Gets and sets the property DnsIpAddrs. 
        /// <para>
        /// The IP addresses of the remote DNS server associated with RemoteDomainName. This is
        /// the IP address of the DNS server that your conditional forwarder points to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsIpAddrs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DnsIpAddrs property is set.
        /// </summary>
        internal bool IsSetDnsIpAddrs() => this.DnsIpAddrs != null && (this.DnsIpAddrs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DnsIpv6Addrs. 
        /// <para>
        /// The IPv6 addresses of the remote DNS server associated with RemoteDomainName. This
        /// is the IPv6 address of the DNS server that your conditional forwarder points to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsIpv6Addrs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DnsIpv6Addrs property is set.
        /// </summary>
        internal bool IsSetDnsIpv6Addrs() => this.DnsIpv6Addrs != null && (this.DnsIpv6Addrs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RemoteDomainName. 
        /// <para>
        /// The fully qualified domain name (FQDN) of the remote domains pointed to by the conditional
        /// forwarder.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string RemoteDomainName { get; set; }

        /// <summary>
        /// Checks to see if the RemoteDomainName property is set.
        /// </summary>
        internal bool IsSetRemoteDomainName() => this.RemoteDomainName != null;

        /// <summary>
        /// Gets and sets the property ReplicationScope. 
        /// <para>
        /// The replication scope of the conditional forwarder. The only allowed value is <c>Domain</c>,
        /// which will replicate the conditional forwarder to all of the domain controllers for
        /// your Amazon Web Services directory.
        /// </para>
        /// </summary>
        public ReplicationScope ReplicationScope { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationScope property is set.
        /// </summary>
        internal bool IsSetReplicationScope() => this.ReplicationScope != null;
    }
}
