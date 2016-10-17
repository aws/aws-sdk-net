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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the CreateHostedZone operation.
    /// Creates a new public hosted zone, used to specify how the Domain Name System (DNS)
    /// routes traffic on the Internet for a domain, such as example.com, and its subdomains.
    /// 
    /// 
    ///  <important> 
    /// <para>
    /// Public hosted zones cannot be converted to a private hosted zone or vice versa. Instead,
    /// create a new hosted zone with the same name and create new resource record sets.
    /// </para>
    ///  </important> 
    /// <para>
    /// Send a <code>POST</code> request to the <code>/2013-04-01/hostedzone</code> resource.
    /// The request body must include an XML document with a <code>CreateHostedZoneRequest</code>
    /// element. The response returns the <code>CreateHostedZoneResponse</code> element containing
    /// metadata about the hosted zone.
    /// </para>
    ///  
    /// <para>
    /// Fore more information about charges for hosted zones, see <a href="http://aws.amazon.com/route53/pricing/">Amazon
    /// Route 53 Pricing</a>.
    /// </para>
    ///  
    /// <para>
    /// Note the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You cannot create a hosted zone for a top-level domain (TLD).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Route 53 automatically creates a default SOA record and four NS records for
    /// the zone. For more information about SOA and NS records, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/SOA-NSrecords.html">NS
    /// and SOA Records that Amazon Route 53 Creates for a Hosted Zone</a> in the <i>Amazon
    /// Route 53 Developer Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If your domain is registered with a registrar other than Amazon Route 53, you must
    /// update the name servers with your registrar to make Amazon Route 53 your DNS service.
    /// For more information, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/creating-migrating.html">Configuring
    /// Amazon Route 53 as your DNS Service</a> in the <i>Amazon Route 53 Developer's Guide</i>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// After creating a zone, its initial status is <code>PENDING</code>. This means that
    /// it is not yet available on all DNS servers. The status of the zone changes to <code>INSYNC</code>
    /// when the NS and SOA records are available on all Amazon Route 53 DNS servers. 
    /// </para>
    ///  
    /// <para>
    /// When trying to create a hosted zone using a reusable delegation set, specify an optional
    /// DelegationSetId, and Amazon Route 53 would assign those 4 NS records for the zone,
    /// instead of allotting a new one.
    /// </para>
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
        /// <param name="name">The name of the domain. For resource record types that include a domain name, specify a fully qualified domain name, for example, <i>www.example.com</i>. The trailing dot is optional; Amazon Route 53 assumes that the domain name is fully qualified. This means that Amazon Route 53 treats <i>www.example.com</i> (without a trailing dot) and <i>www.example.com.</i> (with a trailing dot) as identical. If you're creating a public hosted zone, this is the name you have registered with your DNS registrar. If your domain name is registered with a registrar other than Amazon Route 53, change the name servers for your domain to the set of <code>NameServers</code> that <code>CreateHostedZone</code> returns in the DelegationSet element.</param>
        /// <param name="callerReference">A unique string that identifies the request and that allows failed <code>CreateHostedZone</code> requests to be retried without the risk of executing the operation twice. You must use a unique <code>CallerReference</code> string every time you create a hosted zone. <code>CallerReference</code> can be any unique string, for example, a date/time stamp.</param>
        public CreateHostedZoneRequest(string name, string callerReference)
        {
            _name = name;
            _callerReference = callerReference;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the domain. For resource record types that include a domain name, specify
        /// a fully qualified domain name, for example, <i>www.example.com</i>. The trailing dot
        /// is optional; Amazon Route 53 assumes that the domain name is fully qualified. This
        /// means that Amazon Route 53 treats <i>www.example.com</i> (without a trailing dot)
        /// and <i>www.example.com.</i> (with a trailing dot) as identical.
        /// </para>
        ///  
        /// <para>
        /// If you're creating a public hosted zone, this is the name you have registered with
        /// your DNS registrar. If your domain name is registered with a registrar other than
        /// Amazon Route 53, change the name servers for your domain to the set of <code>NameServers</code>
        /// that <code>CreateHostedZone</code> returns in the DelegationSet element.
        /// </para>
        /// </summary>
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
        /// The VPC that you want your hosted zone to be associated with. By providing this parameter,
        /// your newly created hosted cannot be resolved anywhere other than the given VPC.
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
        /// A unique string that identifies the request and that allows failed <code>CreateHostedZone</code>
        /// requests to be retried without the risk of executing the operation twice. You must
        /// use a unique <code>CallerReference</code> string every time you create a hosted zone.
        /// <code>CallerReference</code> can be any unique string, for example, a date/time stamp.
        /// </para>
        /// </summary>
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
        ///  (Optional) A complex type that contains an optional comment about your hosted zone.
        /// If you don't want to specify a comment, omit both the <code>HostedZoneConfig</code>
        /// and <code>Comment</code> elements.
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
        /// Amazon Route 53 assigned to the reusable delegation set when you created it. For more
        /// information about reusable delegation sets, see <a>CreateReusableDelegationSet</a>.
        /// </para>
        ///  <dl> <dt>Type</dt> <dd> 
        /// <para>
        /// String
        /// </para>
        ///  </dd> <dt>Default</dt> <dd> 
        /// <para>
        /// None
        /// </para>
        ///  </dd> <dt>Parent</dt> <dd> 
        /// <para>
        ///  <code>CreatedHostedZoneRequest</code> 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
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