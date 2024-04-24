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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
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
namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// A complex type that contains the ID for the Route 53 hosted zone that Cloud Map creates
    /// when you create a namespace.
    /// </summary>
    public partial class DnsProperties
    {
        private string _hostedZoneId;
        private SOA _soa;

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID for the Route 53 hosted zone that Cloud Map creates when you create a namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string HostedZoneId
        {
            get { return this._hostedZoneId; }
            set { this._hostedZoneId = value; }
        }

        // Check to see if HostedZoneId property is set
        internal bool IsSetHostedZoneId()
        {
            return this._hostedZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property SOA. 
        /// <para>
        /// Start of Authority (SOA) record for the hosted zone.
        /// </para>
        /// </summary>
        public SOA SOA
        {
            get { return this._soa; }
            set { this._soa = value; }
        }

        // Check to see if SOA property is set
        internal bool IsSetSOA()
        {
            return this._soa != null;
        }

    }
}