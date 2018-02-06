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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// A complex type that contains information about changes to the records that Route 53
    /// creates when you register an instance.
    /// </summary>
    public partial class DnsConfigChange
    {
        private List<DnsRecord> _dnsRecords = new List<DnsRecord>();

        /// <summary>
        /// Gets and sets the property DnsRecords. 
        /// <para>
        /// An array that contains one <code>DnsRecord</code> object for each record that you
        /// want Route 53 to create when you register an instance.
        /// </para>
        /// </summary>
        public List<DnsRecord> DnsRecords
        {
            get { return this._dnsRecords; }
            set { this._dnsRecords = value; }
        }

        // Check to see if DnsRecords property is set
        internal bool IsSetDnsRecords()
        {
            return this._dnsRecords != null && this._dnsRecords.Count > 0; 
        }

    }
}