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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
    /// Container for the parameters to the CreateConditionalForwarder operation.
    /// Creates a conditional forwarder associated with your Amazon Web Services directory.
    /// Conditional forwarders are required in order to set up a trust relationship with another
    /// domain. The conditional forwarder points to the trusted domain.
    /// </summary>
    public partial class CreateConditionalForwarderRequest : AmazonDirectoryServiceRequest
    {
        private string _directoryId;
        private List<string> _dnsIpAddrs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _dnsIpv6Addrs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _remoteDomainName;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The directory ID of the Amazon Web Services directory for which you are creating the
        /// conditional forwarder.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property DnsIpAddrs. 
        /// <para>
        /// The IP addresses of the remote DNS server associated with RemoteDomainName.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsIpAddrs
        {
            get { return this._dnsIpAddrs; }
            set { this._dnsIpAddrs = value; }
        }

        // Check to see if DnsIpAddrs property is set
        internal bool IsSetDnsIpAddrs()
        {
            return this._dnsIpAddrs != null && (this._dnsIpAddrs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DnsIpv6Addrs. 
        /// <para>
        /// The IPv6 addresses of the remote DNS server associated with RemoteDomainName.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsIpv6Addrs
        {
            get { return this._dnsIpv6Addrs; }
            set { this._dnsIpv6Addrs = value; }
        }

        // Check to see if DnsIpv6Addrs property is set
        internal bool IsSetDnsIpv6Addrs()
        {
            return this._dnsIpv6Addrs != null && (this._dnsIpv6Addrs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RemoteDomainName. 
        /// <para>
        /// The fully qualified domain name (FQDN) of the remote domain with which you will set
        /// up a trust relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
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

    }
}