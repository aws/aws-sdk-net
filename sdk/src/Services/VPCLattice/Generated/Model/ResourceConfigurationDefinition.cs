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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
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
namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Describes a resource configuration.
    /// </summary>
    public partial class ResourceConfigurationDefinition
    {
        private ArnResource _arnResource;
        private DnsResource _dnsResource;
        private IpResource _ipResource;

        /// <summary>
        /// Gets and sets the property ArnResource. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        public ArnResource ArnResource
        {
            get { return this._arnResource; }
            set { this._arnResource = value; }
        }

        // Check to see if ArnResource property is set
        internal bool IsSetArnResource()
        {
            return this._arnResource != null;
        }

        /// <summary>
        /// Gets and sets the property DnsResource. 
        /// <para>
        /// The DNS name of the resource.
        /// </para>
        /// </summary>
        public DnsResource DnsResource
        {
            get { return this._dnsResource; }
            set { this._dnsResource = value; }
        }

        // Check to see if DnsResource property is set
        internal bool IsSetDnsResource()
        {
            return this._dnsResource != null;
        }

        /// <summary>
        /// Gets and sets the property IpResource. 
        /// <para>
        /// The IP resource.
        /// </para>
        /// </summary>
        public IpResource IpResource
        {
            get { return this._ipResource; }
            set { this._ipResource = value; }
        }

        // Check to see if IpResource property is set
        internal bool IsSetIpResource()
        {
            return this._ipResource != null;
        }

    }
}