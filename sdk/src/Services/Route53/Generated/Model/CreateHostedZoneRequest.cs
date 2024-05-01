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
    /// Container for the parameters to the CreateHostedZone operation.
    /// Creates a new public or private hosted zone. You create records in a public hosted
    /// zone to define how you want to route traffic on the internet for a domain, such as
    /// example.com, and its subdomains (apex.example.com, acme.example.com). You create records
    /// in a private hosted zone to define how you want to route traffic for a domain and
    /// its subdomains within one or more Amazon Virtual Private Clouds (Amazon VPCs). 
    /// 
    ///  <important> 
    /// <para>
    /// You can't convert a public hosted zone to a private hosted zone or vice versa. Instead,
    /// you must create a new hosted zone with the same name and create new resource record
    /// sets.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information about charges for hosted zones, see <a href="http://aws.amazon.com/route53/pricing/">Amazon
    /// Route 53 Pricing</a>.
    /// </para>
    ///  
    /// <para>
    /// Note the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can't create a hosted zone for a top-level domain (TLD) such as .com.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For public hosted zones, Route 53 automatically creates a default SOA record and four
    /// NS records for the zone. For more information about SOA and NS records, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/SOA-NSrecords.html">NS
    /// and SOA Records that Route 53 Creates for a Hosted Zone</a> in the <i>Amazon Route
    /// 53 Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you want to use the same name servers for multiple public hosted zones, you can
    /// optionally associate a reusable delegation set with the hosted zone. See the <c>DelegationSetId</c>
    /// element.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If your domain is registered with a registrar other than Route 53, you must update
    /// the name servers with your registrar to make Route 53 the DNS service for the domain.
    /// For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/MigratingDNS.html">Migrating
    /// DNS Service for an Existing Domain to Amazon Route 53</a> in the <i>Amazon Route 53
    /// Developer Guide</i>. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When you submit a <c>CreateHostedZone</c> request, the initial status of the hosted
    /// zone is <c>PENDING</c>. For public hosted zones, this means that the NS and SOA records
    /// are not yet available on all Route 53 DNS servers. When the NS and SOA records are
    /// available, the status of the zone changes to <c>INSYNC</c>.
    /// </para>
    ///  
    /// <para>
    /// The <c>CreateHostedZone</c> request requires the caller to have an <c>ec2:DescribeVpcs</c>
    /// permission.
    /// </para>
    ///  <note> 
    /// <para>
    /// When creating private hosted zones, the Amazon VPC must belong to the same partition
    /// where the hosted zone is created. A partition is a group of Amazon Web Services Regions.
    /// Each Amazon Web Services account is scoped to one partition.
    /// </para>
    ///  
    /// <para>
    /// The following are the supported partitions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>aws</c> - Amazon Web Services Regions
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>aws-cn</c> - China Regions
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>aws-us-gov</c> - Amazon Web Services GovCloud (US) Region
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Access
    /// Management</a> in the <i>Amazon Web Services General Reference</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateHostedZoneRequest : AmazonRoute53Request
    {
        private string _name;
        private VPC _vpc;
        private string _callerReference;
        private HostedZoneConfig _hostedZoneConfig;
        private string _delegationSetId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateHostedZoneRequest() { }

        /// <summary>
        /// Instantiates CreateHostedZoneRequest with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the domain. Specify a fully qualified domain name, for example, <i>www.example.com</i>. The trailing dot is optional; Amazon Route 53 assumes that the domain name is fully qualified. This means that Route 53 treats <i>www.example.com</i> (without a trailing dot) and <i>www.example.com.</i> (with a trailing dot) as identical. If you're creating a public hosted zone, this is the name you have registered with your DNS registrar. If your domain name is registered with a registrar other than Route 53, change the name servers for your domain to the set of <c>NameServers</c> that <c>CreateHostedZone</c> returns in <c>DelegationSet</c>.</param>
        /// <param name="callerReference">A unique string that identifies the request and that allows failed <c>CreateHostedZone</c> requests to be retried without the risk of executing the operation twice. You must use a unique <c>CallerReference</c> string every time you submit a <c>CreateHostedZone</c> request. <c>CallerReference</c> can be any unique string, for example, a date/time stamp.</param>
        public CreateHostedZoneRequest(string name, string callerReference)
        {
            _name = name;
            _callerReference = callerReference;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the domain. Specify a fully qualified domain name, for example, <i>www.example.com</i>.
        /// The trailing dot is optional; Amazon Route 53 assumes that the domain name is fully
        /// qualified. This means that Route 53 treats <i>www.example.com</i> (without a trailing
        /// dot) and <i>www.example.com.</i> (with a trailing dot) as identical.
        /// </para>
        ///  
        /// <para>
        /// If you're creating a public hosted zone, this is the name you have registered with
        /// your DNS registrar. If your domain name is registered with a registrar other than
        /// Route 53, change the name servers for your domain to the set of <c>NameServers</c>
        /// that <c>CreateHostedZone</c> returns in <c>DelegationSet</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property VPC. 
        /// <para>
        /// (Private hosted zones only) A complex type that contains information about the Amazon
        /// VPC that you're associating with this hosted zone.
        /// </para>
        ///  
        /// <para>
        /// You can specify only one Amazon VPC when you create a private hosted zone. If you
        /// are associating a VPC with a hosted zone with this request, the paramaters <c>VPCId</c>
        /// and <c>VPCRegion</c> are also required.
        /// </para>
        ///  
        /// <para>
        /// To associate additional Amazon VPCs with the hosted zone, use <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_AssociateVPCWithHostedZone.html">AssociateVPCWithHostedZone</a>
        /// after you create a hosted zone.
        /// </para>
        /// </summary>
        public VPC VPC
        {
            get { return this._vpc; }
            set { this._vpc = value; }
        }

        // Check to see if VPC property is set
        internal bool IsSetVPC()
        {
            return this._vpc != null;
        }

        /// <summary>
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A unique string that identifies the request and that allows failed <c>CreateHostedZone</c>
        /// requests to be retried without the risk of executing the operation twice. You must
        /// use a unique <c>CallerReference</c> string every time you submit a <c>CreateHostedZone</c>
        /// request. <c>CallerReference</c> can be any unique string, for example, a date/time
        /// stamp.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string CallerReference
        {
            get { return this._callerReference; }
            set { this._callerReference = value; }
        }

        // Check to see if CallerReference property is set
        internal bool IsSetCallerReference()
        {
            return this._callerReference != null;
        }

        /// <summary>
        /// Gets and sets the property HostedZoneConfig. 
        /// <para>
        /// (Optional) A complex type that contains the following optional values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For public and private hosted zones, an optional comment
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For private hosted zones, an optional <c>PrivateZone</c> element
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a comment or the <c>PrivateZone</c> element, omit <c>HostedZoneConfig</c>
        /// and the other elements.
        /// </para>
        /// </summary>
        public HostedZoneConfig HostedZoneConfig
        {
            get { return this._hostedZoneConfig; }
            set { this._hostedZoneConfig = value; }
        }

        // Check to see if HostedZoneConfig property is set
        internal bool IsSetHostedZoneConfig()
        {
            return this._hostedZoneConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DelegationSetId. 
        /// <para>
        /// If you want to associate a reusable delegation set with this hosted zone, the ID that
        /// Amazon Route 53 assigned to the reusable delegation set when you created it. For more
        /// information about reusable delegation sets, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_CreateReusableDelegationSet.html">CreateReusableDelegationSet</a>.
        /// </para>
        ///  
        /// <para>
        /// If you are using a reusable delegation set to create a public hosted zone for a subdomain,
        /// make sure that the parent hosted zone doesn't use one or more of the same name servers.
        /// If you have overlapping nameservers, the operation will cause a <c>ConflictingDomainsExist</c>
        /// error.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32)]
        public string DelegationSetId
        {
            get { return this._delegationSetId; }
            set { this._delegationSetId = value; }
        }

        // Check to see if DelegationSetId property is set
        internal bool IsSetDelegationSetId()
        {
            return this._delegationSetId != null;
        }

    }
}