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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the TestDNSAnswer operation.
    /// Gets the value that Amazon Route 53 returns in response to a DNS request for a specified
    /// record name and type. You can optionally specify the IP address of a DNS resolver,
    /// an EDNS0 client subnet IP address, and a subnet mask. 
    /// 
    ///  
    /// <para>
    /// This call only supports querying public hosted zones.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <c>TestDnsAnswer </c> returns information similar to what you would expect from
    /// the answer section of the <c>dig</c> command. Therefore, if you query for the name
    /// servers of a subdomain that point to the parent name servers, those will not be returned.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class TestDNSAnswerRequest : AmazonRoute53Request
    {
        private string _hostedZoneId;
        private string _recordName;
        private RRType _recordType;
        private string _resolverIP;
        private string _edns0ClientSubnetIP;
        private string _edns0ClientSubnetMask;

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the hosted zone that you want Amazon Route 53 to simulate a query for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=32)]
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
        /// Gets and sets the property RecordName. 
        /// <para>
        /// The name of the resource record set that you want Amazon Route 53 to simulate a query
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string RecordName
        {
            get { return this._recordName; }
            set { this._recordName = value; }
        }

        // Check to see if RecordName property is set
        internal bool IsSetRecordName()
        {
            return this._recordName != null;
        }

        /// <summary>
        /// Gets and sets the property RecordType. 
        /// <para>
        /// The type of the resource record set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RRType RecordType
        {
            get { return this._recordType; }
            set { this._recordType = value; }
        }

        // Check to see if RecordType property is set
        internal bool IsSetRecordType()
        {
            return this._recordType != null;
        }

        /// <summary>
        /// Gets and sets the property ResolverIP. 
        /// <para>
        /// If you want to simulate a request from a specific DNS resolver, specify the IP address
        /// for that resolver. If you omit this value, <c>TestDnsAnswer</c> uses the IP address
        /// of a DNS resolver in the Amazon Web Services US East (N. Virginia) Region (<c>us-east-1</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Max=45)]
        public string ResolverIP
        {
            get { return this._resolverIP; }
            set { this._resolverIP = value; }
        }

        // Check to see if ResolverIP property is set
        internal bool IsSetResolverIP()
        {
            return this._resolverIP != null;
        }

        /// <summary>
        /// Gets and sets the property EDNS0ClientSubnetIP. 
        /// <para>
        /// If the resolver that you specified for resolverip supports EDNS0, specify the IPv4
        /// or IPv6 address of a client in the applicable location, for example, <c>192.0.2.44</c>
        /// or <c>2001:db8:85a3::8a2e:370:7334</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=45)]
        public string EDNS0ClientSubnetIP
        {
            get { return this._edns0ClientSubnetIP; }
            set { this._edns0ClientSubnetIP = value; }
        }

        // Check to see if EDNS0ClientSubnetIP property is set
        internal bool IsSetEDNS0ClientSubnetIP()
        {
            return this._edns0ClientSubnetIP != null;
        }

        /// <summary>
        /// Gets and sets the property EDNS0ClientSubnetMask. 
        /// <para>
        /// If you specify an IP address for <c>edns0clientsubnetip</c>, you can optionally specify
        /// the number of bits of the IP address that you want the checking tool to include in
        /// the DNS query. For example, if you specify <c>192.0.2.44</c> for <c>edns0clientsubnetip</c>
        /// and <c>24</c> for <c>edns0clientsubnetmask</c>, the checking tool will simulate a
        /// request from 192.0.2.0/24. The default value is 24 bits for IPv4 addresses and 64
        /// bits for IPv6 addresses.
        /// </para>
        ///  
        /// <para>
        /// The range of valid values depends on whether <c>edns0clientsubnetip</c> is an IPv4
        /// or an IPv6 address:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>IPv4</b>: Specify a value between 0 and 32
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IPv6</b>: Specify a value between 0 and 128
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public string EDNS0ClientSubnetMask
        {
            get { return this._edns0ClientSubnetMask; }
            set { this._edns0ClientSubnetMask = value; }
        }

        // Check to see if EDNS0ClientSubnetMask property is set
        internal bool IsSetEDNS0ClientSubnetMask()
        {
            return this._edns0ClientSubnetMask != null;
        }

    }
}