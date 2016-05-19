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
    /// Container for the parameters to the UpdateConditionalForwarder operation.
    /// Updates a conditional forwarder that has been set up for your AWS directory.
    /// </summary>
    public partial class UpdateConditionalForwarderRequest : AmazonDirectoryServiceRequest
    {
        private string _directoryId;
        private List<string> _dnsIpAddrs = new List<string>();
        private string _remoteDomainName;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The directory ID of the AWS directory for which to update the conditional forwarder.
        /// </para>
        /// </summary>
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
        /// The updated IP addresses of the remote DNS server associated with the conditional
        /// forwarder.
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
        /// The fully qualified domain name (FQDN) of the remote domain with which you will set
        /// up a trust relationship.
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

    }
}