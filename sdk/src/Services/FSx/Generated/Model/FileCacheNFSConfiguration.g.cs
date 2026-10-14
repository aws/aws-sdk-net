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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The configuration for an NFS data repository association (DRA) created during the
    /// creation of the Amazon File Cache resource.
    /// </summary>
    public partial class FileCacheNFSConfiguration
    {
        /// <summary>
        /// Gets and sets the property DnsIps. 
        /// <para>
        /// A list of up to 2 IP addresses of DNS servers used to resolve the NFS file system
        /// domain name. The provided IP addresses can either be the IP addresses of a DNS forwarder
        /// or resolver that the customer manages and runs inside the customer VPC, or the IP
        /// addresses of the on-premises DNS servers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> DnsIps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DnsIps property is set.
        /// </summary>
        internal bool IsSetDnsIps() => this.DnsIps != null && (this.DnsIps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the NFS (Network File System) protocol of the NFS data repository.
        /// The only supported value is <c>NFS3</c>, which indicates that the data repository
        /// must support the NFSv3 protocol.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NfsVersion Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
