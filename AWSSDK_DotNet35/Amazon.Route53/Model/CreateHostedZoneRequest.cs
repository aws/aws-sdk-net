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
    /// This action creates a new hosted zone.
    /// 
    ///  
    /// <para>
    /// To create a new hosted zone, send a <code>POST</code> request to the <code>2013-04-01/hostedzone</code>
    /// resource. The request body must include an XML document with a <code>CreateHostedZoneRequest</code>
    /// element. The response returns the <code>CreateHostedZoneResponse</code> element that
    /// contains metadata about the hosted zone.
    /// </para>
    ///  
    /// <para>
    /// Route 53 automatically creates a default SOA record and four NS records for the zone.
    /// The NS records in the hosted zone are the name servers you give your registrar to
    /// delegate your domain to. For more information about SOA and NS records, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/SOA-NSrecords.html">NS
    /// and SOA Records that Route 53 Creates for a Hosted Zone</a> in the <i>Amazon Route
    /// 53 Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// When you create a zone, its initial status is <code>PENDING</code>. This means that
    /// it is not yet available on all DNS servers. The status of the zone changes to <code>INSYNC</code>
    /// when the NS and SOA records are available on all Route 53 DNS servers. 
    /// </para>
    ///  
    /// <para>
    /// When trying to create a hosted zone using a reusable delegation set, you could specify
    /// an optional DelegationSetId, and Route53 would assign those 4 NS records for the zone,
    /// instead of alloting a new one.
    /// </para>
    /// </summary>
    public partial class CreateHostedZoneRequest : AmazonRoute53Request
    {
        private string _name;
        private VPC _vPC;
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
        /// <param name="name">The name of the domain. This must be a fully-specified domain, for example, www.example.com. The trailing dot is optional; Route 53 assumes that the domain name is fully qualified. This means that Route 53 treats www.example.com (without a trailing dot) and www.example.com. (with a trailing dot) as identical. This is the name you have registered with your DNS registrar. You should ask your registrar to change the authoritative name servers for your domain to the set of <code>NameServers</code> elements returned in <code>DelegationSet</code>.</param>
        /// <param name="callerReference">A unique string that identifies the request and that allows failed <code>CreateHostedZone</code> requests to be retried without the risk of executing the operation twice. You must use a unique <code>CallerReference</code> string every time you create a hosted zone. <code>CallerReference</code> can be any unique string; you might choose to use a string that identifies your project, such as <code>DNSMigration_01</code>. Valid characters are any Unicode code points that are legal in an XML 1.0 document. The UTF-8 encoding of the value must be less than 128 bytes.</param>
        public CreateHostedZoneRequest(string name, string callerReference)
        {
            _name = name;
            _callerReference = callerReference;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the domain. This must be a fully-specified domain, for example, www.example.com.
        /// The trailing dot is optional; Route 53 assumes that the domain name is fully qualified.
        /// This means that Route 53 treats www.example.com (without a trailing dot) and www.example.com.
        /// (with a trailing dot) as identical.
        /// </para>
        ///  
        /// <para>
        /// This is the name you have registered with your DNS registrar. You should ask your
        /// registrar to change the authoritative name servers for your domain to the set of <code>NameServers</code>
        /// elements returned in <code>DelegationSet</code>.
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
            get { return this._vPC; }
            set { this._vPC = value; }
        }

        // Check to see if VPC property is set
        internal bool IsSetVPC()
        {
            return this._vPC != null;
        }

        /// <summary>
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A unique string that identifies the request and that allows failed <code>CreateHostedZone</code>
        /// requests to be retried without the risk of executing the operation twice. You must
        /// use a unique <code>CallerReference</code> string every time you create a hosted zone.
        /// <code>CallerReference</code> can be any unique string; you might choose to use a string
        /// that identifies your project, such as <code>DNSMigration_01</code>.
        /// </para>
        ///  
        /// <para>
        /// Valid characters are any Unicode code points that are legal in an XML 1.0 document.
        /// The UTF-8 encoding of the value must be less than 128 bytes.
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
        /// A complex type that contains an optional comment about your hosted zone.
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
        /// The delegation set id of the reusable delgation set whose NS records you want to assign
        /// to the new hosted zone.
        /// </para>
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