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
    /// Information about the resource record set to create or delete.
    /// </summary>
    public partial class ResourceRecordSet
    {
        private string _name;
        private RRType _type;
        private string _setIdentifier;
        private long? _weight;
        private ResourceRecordSetRegion _region;
        private GeoLocation _geoLocation;
        private ResourceRecordSetFailover _failover;
        private bool? _multiValueAnswer;
        private long? _ttl;
        private List<ResourceRecord> _resourceRecords = AWSConfigs.InitializeCollections ? new List<ResourceRecord>() : null;
        private AliasTarget _aliasTarget;
        private string _healthCheckId;
        private string _trafficPolicyInstanceId;
        private CidrRoutingConfig _cidrRoutingConfig;
        private GeoProximityLocation _geoProximityLocation;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ResourceRecordSet() { }

        /// <summary>
        /// Instantiates ResourceRecordSet with the parameterized properties
        /// </summary>
        /// <param name="name">For <c>ChangeResourceRecordSets</c> requests, the name of the record that you want to create, update, or delete. For <c>ListResourceRecordSets</c> responses, the name of a record in the specified hosted zone.  <b>ChangeResourceRecordSets Only</b>  Enter a fully qualified domain name, for example, <c>www.example.com</c>. You can optionally include a trailing dot. If you omit the trailing dot, Amazon Route 53 assumes that the domain name that you specify is fully qualified. This means that Route 53 treats <c>www.example.com</c> (without a trailing dot) and <c>www.example.com.</c> (with a trailing dot) as identical. For information about how to specify characters other than <c>a-z</c>, <c>0-9</c>, and <c>-</c> (hyphen) and how to specify internationalized domain names, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DomainNameFormat.html">DNS Domain Name Format</a> in the <i>Amazon Route 53 Developer Guide</i>. You can use the asterisk (*) wildcard to replace the leftmost label in a domain name, for example, <c>*.example.com</c>. Note the following: <ul> <li> The * must replace the entire label. For example, you can't specify <c>*prod.example.com</c> or <c>prod*.example.com</c>. </li> <li> The * can't replace any of the middle labels, for example, marketing.*.example.com. </li> <li> If you include * in any position other than the leftmost label in a domain name, DNS treats it as an * character (ASCII 42), not as a wildcard. <important> You can't use the * wildcard for resource records sets that have a type of NS. </important> </li> </ul></param>
        /// <param name="type">The DNS record type. For information about different record types and how data is encoded for them, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/ResourceRecordTypes.html">Supported DNS Resource Record Types</a> in the <i>Amazon Route 53 Developer Guide</i>. Valid values for basic resource record sets: <c>A</c> | <c>AAAA</c> | <c>CAA</c> | <c>CNAME</c> | <c>DS</c> |<c>MX</c> | <c>NAPTR</c> | <c>NS</c> | <c>PTR</c> | <c>SOA</c> | <c>SPF</c> | <c>SRV</c> | <c>TXT</c>| <c>TLSA</c>| <c>SSHFP</c>| <c>SVCB</c>| <c>HTTPS</c>  Values for weighted, latency, geolocation, and failover resource record sets: <c>A</c> | <c>AAAA</c> | <c>CAA</c> | <c>CNAME</c> | <c>MX</c> | <c>NAPTR</c> | <c>PTR</c> | <c>SPF</c> | <c>SRV</c> | <c>TXT</c>| <c>TLSA</c>| <c>SSHFP</c>| <c>SVCB</c>| <c>HTTPS</c>. When creating a group of weighted, latency, geolocation, or failover resource record sets, specify the same value for all of the resource record sets in the group. Valid values for multivalue answer resource record sets: <c>A</c> | <c>AAAA</c> | <c>MX</c> | <c>NAPTR</c> | <c>PTR</c> | <c>SPF</c> | <c>SRV</c> | <c>TXT</c>| <c>CAA</c>| <c>TLSA</c>| <c>SSHFP</c>| <c>SVCB</c>| <c>HTTPS</c>  <note> SPF records were formerly used to verify the identity of the sender of email messages. However, we no longer recommend that you create resource record sets for which the value of <c>Type</c> is <c>SPF</c>. RFC 7208, <i>Sender Policy Framework (SPF) for Authorizing Use of Domains in Email, Version 1</i>, has been updated to say, "...[I]ts existence and mechanism defined in [RFC4408] have led to some interoperability issues. Accordingly, its use is no longer appropriate for SPF version 1; implementations are not to use it." In RFC 7208, see section 14.1, <a href="http://tools.ietf.org/html/rfc7208#section-14.1">The SPF DNS Record Type</a>. </note> Values for alias resource record sets: <ul> <li>  <b>Amazon API Gateway custom regional APIs and edge-optimized APIs:</b> <c>A</c>  </li> <li>  <b>CloudFront distributions:</b> <c>A</c>  If IPv6 is enabled for the distribution, create two resource record sets to route traffic to your distribution, one with a value of <c>A</c> and one with a value of <c>AAAA</c>.  </li> <li>  <b>Amazon API Gateway environment that has a regionalized subdomain</b>: <c>A</c>  </li> <li>  <b>ELB load balancers:</b> <c>A</c> | <c>AAAA</c>  </li> <li>  <b>Amazon S3 buckets:</b> <c>A</c>  </li> <li>  <b>Amazon Virtual Private Cloud interface VPC endpoints</b> <c>A</c>  </li> <li>  <b>Another resource record set in this hosted zone:</b> Specify the type of the resource record set that you're creating the alias for. All values are supported except <c>NS</c> and <c>SOA</c>. <note> If you're creating an alias record that has the same name as the hosted zone (known as the zone apex), you can't route traffic to a record for which the value of <c>Type</c> is <c>CNAME</c>. This is because the alias record must have the same type as the record you're routing traffic to, and creating a CNAME record for the zone apex isn't supported even for an alias record. </note> </li> </ul></param>
        public ResourceRecordSet(string name, RRType type)
        {
            _name = name;
            _type = type;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// For <c>ChangeResourceRecordSets</c> requests, the name of the record that you want
        /// to create, update, or delete. For <c>ListResourceRecordSets</c> responses, the name
        /// of a record in the specified hosted zone.
        /// </para>
        ///  
        /// <para>
        ///  <b>ChangeResourceRecordSets Only</b> 
        /// </para>
        ///  
        /// <para>
        /// Enter a fully qualified domain name, for example, <c>www.example.com</c>. You can
        /// optionally include a trailing dot. If you omit the trailing dot, Amazon Route 53 assumes
        /// that the domain name that you specify is fully qualified. This means that Route 53
        /// treats <c>www.example.com</c> (without a trailing dot) and <c>www.example.com.</c>
        /// (with a trailing dot) as identical.
        /// </para>
        ///  
        /// <para>
        /// For information about how to specify characters other than <c>a-z</c>, <c>0-9</c>,
        /// and <c>-</c> (hyphen) and how to specify internationalized domain names, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DomainNameFormat.html">DNS
        /// Domain Name Format</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can use the asterisk (*) wildcard to replace the leftmost label in a domain name,
        /// for example, <c>*.example.com</c>. Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The * must replace the entire label. For example, you can't specify <c>*prod.example.com</c>
        /// or <c>prod*.example.com</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The * can't replace any of the middle labels, for example, marketing.*.example.com.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you include * in any position other than the leftmost label in a domain name, DNS
        /// treats it as an * character (ASCII 42), not as a wildcard.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can't use the * wildcard for resource records sets that have a type of NS.
        /// </para>
        ///  </important> </li> </ul>
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The DNS record type. For information about different record types and how data is
        /// encoded for them, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/ResourceRecordTypes.html">Supported
        /// DNS Resource Record Types</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid values for basic resource record sets: <c>A</c> | <c>AAAA</c> | <c>CAA</c> |
        /// <c>CNAME</c> | <c>DS</c> |<c>MX</c> | <c>NAPTR</c> | <c>NS</c> | <c>PTR</c> | <c>SOA</c>
        /// | <c>SPF</c> | <c>SRV</c> | <c>TXT</c>| <c>TLSA</c>| <c>SSHFP</c>| <c>SVCB</c>| <c>HTTPS</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Values for weighted, latency, geolocation, and failover resource record sets: <c>A</c>
        /// | <c>AAAA</c> | <c>CAA</c> | <c>CNAME</c> | <c>MX</c> | <c>NAPTR</c> | <c>PTR</c>
        /// | <c>SPF</c> | <c>SRV</c> | <c>TXT</c>| <c>TLSA</c>| <c>SSHFP</c>| <c>SVCB</c>| <c>HTTPS</c>.
        /// When creating a group of weighted, latency, geolocation, or failover resource record
        /// sets, specify the same value for all of the resource record sets in the group.
        /// </para>
        ///  
        /// <para>
        /// Valid values for multivalue answer resource record sets: <c>A</c> | <c>AAAA</c> |
        /// <c>MX</c> | <c>NAPTR</c> | <c>PTR</c> | <c>SPF</c> | <c>SRV</c> | <c>TXT</c>| <c>CAA</c>|
        /// <c>TLSA</c>| <c>SSHFP</c>| <c>SVCB</c>| <c>HTTPS</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// SPF records were formerly used to verify the identity of the sender of email messages.
        /// However, we no longer recommend that you create resource record sets for which the
        /// value of <c>Type</c> is <c>SPF</c>. RFC 7208, <i>Sender Policy Framework (SPF) for
        /// Authorizing Use of Domains in Email, Version 1</i>, has been updated to say, "...[I]ts
        /// existence and mechanism defined in [RFC4408] have led to some interoperability issues.
        /// Accordingly, its use is no longer appropriate for SPF version 1; implementations are
        /// not to use it." In RFC 7208, see section 14.1, <a href="http://tools.ietf.org/html/rfc7208#section-14.1">The
        /// SPF DNS Record Type</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Values for alias resource record sets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Amazon API Gateway custom regional APIs and edge-optimized APIs:</b> <c>A</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CloudFront distributions:</b> <c>A</c> 
        /// </para>
        ///  
        /// <para>
        /// If IPv6 is enabled for the distribution, create two resource record sets to route
        /// traffic to your distribution, one with a value of <c>A</c> and one with a value of
        /// <c>AAAA</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon API Gateway environment that has a regionalized subdomain</b>: <c>A</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ELB load balancers:</b> <c>A</c> | <c>AAAA</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon S3 buckets:</b> <c>A</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon Virtual Private Cloud interface VPC endpoints</b> <c>A</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Another resource record set in this hosted zone:</b> Specify the type of the resource
        /// record set that you're creating the alias for. All values are supported except <c>NS</c>
        /// and <c>SOA</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're creating an alias record that has the same name as the hosted zone (known
        /// as the zone apex), you can't route traffic to a record for which the value of <c>Type</c>
        /// is <c>CNAME</c>. This is because the alias record must have the same type as the record
        /// you're routing traffic to, and creating a CNAME record for the zone apex isn't supported
        /// even for an alias record.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public RRType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property SetIdentifier. 
        /// <para>
        ///  <i>Resource record sets that have a routing policy other than simple:</i> An identifier
        /// that differentiates among multiple resource record sets that have the same combination
        /// of name and type, such as multiple weighted resource record sets named acme.example.com
        /// that have a type of A. In a group of resource record sets that have the same name
        /// and type, the value of <c>SetIdentifier</c> must be unique for each resource record
        /// set. 
        /// </para>
        ///  
        /// <para>
        /// For information about routing policies, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html">Choosing
        /// a Routing Policy</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SetIdentifier
        {
            get { return this._setIdentifier; }
            set { this._setIdentifier = value; }
        }

        // Check to see if SetIdentifier property is set
        internal bool IsSetSetIdentifier()
        {
            return this._setIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        ///  <i>Weighted resource record sets only:</i> Among resource record sets that have the
        /// same combination of DNS name and type, a value that determines the proportion of DNS
        /// queries that Amazon Route 53 responds to using the current resource record set. Route
        /// 53 calculates the sum of the weights for the resource record sets that have the same
        /// combination of DNS name and type. Route 53 then responds to queries based on the ratio
        /// of a resource's weight to the total. Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify a value for the <c>Weight</c> element for every weighted resource
        /// record set.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only specify one <c>ResourceRecord</c> per weighted resource record set.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't create latency, failover, or geolocation resource record sets that have
        /// the same values for the <c>Name</c> and <c>Type</c> elements as weighted resource
        /// record sets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can create a maximum of 100 weighted resource record sets that have the same values
        /// for the <c>Name</c> and <c>Type</c> elements.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For weighted (but not weighted alias) resource record sets, if you set <c>Weight</c>
        /// to <c>0</c> for a resource record set, Route 53 never responds to queries with the
        /// applicable value for that resource record set. However, if you set <c>Weight</c> to
        /// <c>0</c> for all resource record sets that have the same combination of DNS name and
        /// type, traffic is routed to all resources with equal probability.
        /// </para>
        ///  
        /// <para>
        /// The effect of setting <c>Weight</c> to <c>0</c> is different when you associate health
        /// checks with weighted resource record sets. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-configuring-options.html">Options
        /// for Configuring Route 53 Active-Active and Active-Passive Failover</a> in the <i>Amazon
        /// Route 53 Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public long? Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this._weight.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        ///  <i>Latency-based resource record sets only:</i> The Amazon EC2 Region where you created
        /// the resource that this resource record set refers to. The resource typically is an
        /// Amazon Web Services resource, such as an EC2 instance or an ELB load balancer, and
        /// is referred to by an IP address or a DNS domain name, depending on the record type.
        /// </para>
        ///  
        /// <para>
        /// When Amazon Route 53 receives a DNS query for a domain name and type for which you
        /// have created latency resource record sets, Route 53 selects the latency resource record
        /// set that has the lowest latency between the end user and the associated Amazon EC2
        /// Region. Route 53 then returns the value that is associated with the selected resource
        /// record set.
        /// </para>
        ///  
        /// <para>
        /// Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can only specify one <c>ResourceRecord</c> per latency resource record set.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only create one latency resource record set for each Amazon EC2 Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You aren't required to create latency resource record sets for all Amazon EC2 Regions.
        /// Route 53 will choose the region with the best latency from among the regions that
        /// you create latency resource record sets for.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't create non-latency resource record sets that have the same values for the
        /// <c>Name</c> and <c>Type</c> elements as latency resource record sets.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public ResourceRecordSetRegion Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property GeoLocation. 
        /// <para>
        ///  <i>Geolocation resource record sets only:</i> A complex type that lets you control
        /// how Amazon Route 53 responds to DNS queries based on the geographic origin of the
        /// query. For example, if you want all queries from Africa to be routed to a web server
        /// with an IP address of <c>192.0.2.111</c>, create a resource record set with a <c>Type</c>
        /// of <c>A</c> and a <c>ContinentCode</c> of <c>AF</c>.
        /// </para>
        ///  
        /// <para>
        /// If you create separate resource record sets for overlapping geographic regions (for
        /// example, one resource record set for a continent and one for a country on the same
        /// continent), priority goes to the smallest geographic region. This allows you to route
        /// most queries for a continent to one resource and to route queries for a country on
        /// that continent to a different resource.
        /// </para>
        ///  
        /// <para>
        /// You can't create two geolocation resource record sets that specify the same geographic
        /// location.
        /// </para>
        ///  
        /// <para>
        /// The value <c>*</c> in the <c>CountryCode</c> element matches all geographic locations
        /// that aren't specified in other geolocation resource record sets that have the same
        /// values for the <c>Name</c> and <c>Type</c> elements.
        /// </para>
        ///  <important> 
        /// <para>
        /// Geolocation works by mapping IP addresses to locations. However, some IP addresses
        /// aren't mapped to geographic locations, so even if you create geolocation resource
        /// record sets that cover all seven continents, Route 53 will receive some DNS queries
        /// from locations that it can't identify. We recommend that you create a resource record
        /// set for which the value of <c>CountryCode</c> is <c>*</c>. Two groups of queries are
        /// routed to the resource that you specify in this record: queries that come from locations
        /// for which you haven't created geolocation resource record sets and queries from IP
        /// addresses that aren't mapped to a location. If you don't create a <c>*</c> resource
        /// record set, Route 53 returns a "no answer" response for queries from those locations.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can't create non-geolocation resource record sets that have the same values for
        /// the <c>Name</c> and <c>Type</c> elements as geolocation resource record sets.
        /// </para>
        /// </summary>
        public GeoLocation GeoLocation
        {
            get { return this._geoLocation; }
            set { this._geoLocation = value; }
        }

        // Check to see if GeoLocation property is set
        internal bool IsSetGeoLocation()
        {
            return this._geoLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Failover. 
        /// <para>
        ///  <i>Failover resource record sets only:</i> To configure failover, you add the <c>Failover</c>
        /// element to two resource record sets. For one resource record set, you specify <c>PRIMARY</c>
        /// as the value for <c>Failover</c>; for the other resource record set, you specify <c>SECONDARY</c>.
        /// In addition, you include the <c>HealthCheckId</c> element and specify the health check
        /// that you want Amazon Route 53 to perform for each resource record set.
        /// </para>
        ///  
        /// <para>
        /// Except where noted, the following failover behaviors assume that you have included
        /// the <c>HealthCheckId</c> element in both resource record sets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When the primary resource record set is healthy, Route 53 responds to DNS queries
        /// with the applicable value from the primary resource record set regardless of the health
        /// of the secondary resource record set.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the primary resource record set is unhealthy and the secondary resource record
        /// set is healthy, Route 53 responds to DNS queries with the applicable value from the
        /// secondary resource record set.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the secondary resource record set is unhealthy, Route 53 responds to DNS queries
        /// with the applicable value from the primary resource record set regardless of the health
        /// of the primary resource record set.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you omit the <c>HealthCheckId</c> element for the secondary resource record set,
        /// and if the primary resource record set is unhealthy, Route 53 always responds to DNS
        /// queries with the applicable value from the secondary resource record set. This is
        /// true regardless of the health of the associated endpoint.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can't create non-failover resource record sets that have the same values for the
        /// <c>Name</c> and <c>Type</c> elements as failover resource record sets.
        /// </para>
        ///  
        /// <para>
        /// For failover alias resource record sets, you must also include the <c>EvaluateTargetHealth</c>
        /// element and set the value to true.
        /// </para>
        ///  
        /// <para>
        /// For more information about configuring failover for Route 53, see the following topics
        /// in the <i>Amazon Route 53 Developer Guide</i>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover.html">Route
        /// 53 Health Checks and DNS Failover</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-private-hosted-zones.html">Configuring
        /// Failover in a Private Hosted Zone</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceRecordSetFailover Failover
        {
            get { return this._failover; }
            set { this._failover = value; }
        }

        // Check to see if Failover property is set
        internal bool IsSetFailover()
        {
            return this._failover != null;
        }

        /// <summary>
        /// Gets and sets the property MultiValueAnswer. 
        /// <para>
        ///  <i>Multivalue answer resource record sets only</i>: To route traffic approximately
        /// randomly to multiple resources, such as web servers, create one multivalue answer
        /// record for each resource and specify <c>true</c> for <c>MultiValueAnswer</c>. Note
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you associate a health check with a multivalue answer resource record set, Amazon
        /// Route 53 responds to DNS queries with the corresponding IP address only when the health
        /// check is healthy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't associate a health check with a multivalue answer record, Route 53 always
        /// considers the record to be healthy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Route 53 responds to DNS queries with up to eight healthy records; if you have eight
        /// or fewer healthy records, Route 53 responds to all DNS queries with all the healthy
        /// records.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you have more than eight healthy records, Route 53 responds to different DNS resolvers
        /// with different combinations of healthy records.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When all records are unhealthy, Route 53 responds to DNS queries with up to eight
        /// unhealthy records.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a resource becomes unavailable after a resolver caches a response, client software
        /// typically tries another of the IP addresses in the response.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can't create multivalue answer alias records.
        /// </para>
        /// </summary>
        public bool? MultiValueAnswer
        {
            get { return this._multiValueAnswer; }
            set { this._multiValueAnswer = value; }
        }

        // Check to see if MultiValueAnswer property is set
        internal bool IsSetMultiValueAnswer()
        {
            return this._multiValueAnswer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TTL. 
        /// <para>
        /// The resource record cache time to live (TTL), in seconds. Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you're creating or updating an alias resource record set, omit <c>TTL</c>. Amazon
        /// Route 53 uses the value of <c>TTL</c> for the alias target. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you're associating this resource record set with a health check (if you're adding
        /// a <c>HealthCheckId</c> element), we recommend that you specify a <c>TTL</c> of 60
        /// seconds or less so clients respond quickly to changes in health status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All of the resource record sets in a group of weighted resource record sets must have
        /// the same value for <c>TTL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a group of weighted resource record sets includes one or more weighted alias resource
        /// record sets for which the alias target is an ELB load balancer, we recommend that
        /// you specify a <c>TTL</c> of 60 seconds for all of the non-alias weighted resource
        /// record sets that have the same name and type. Values other than 60 seconds (the TTL
        /// for load balancers) will change the effect of the values that you specify for <c>Weight</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public long? TTL
        {
            get { return this._ttl; }
            set { this._ttl = value; }
        }

        // Check to see if TTL property is set
        internal bool IsSetTTL()
        {
            return this._ttl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceRecords. 
        /// <para>
        /// Information about the resource records to act upon.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're creating an alias resource record set, omit <c>ResourceRecords</c>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<ResourceRecord> ResourceRecords
        {
            get { return this._resourceRecords; }
            set { this._resourceRecords = value; }
        }

        // Check to see if ResourceRecords property is set
        internal bool IsSetResourceRecords()
        {
            return this._resourceRecords != null && (this._resourceRecords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AliasTarget. 
        /// <para>
        ///  <i>Alias resource record sets only:</i> Information about the Amazon Web Services
        /// resource, such as a CloudFront distribution or an Amazon S3 bucket, that you want
        /// to route traffic to. 
        /// </para>
        ///  
        /// <para>
        /// If you're creating resource records sets for a private hosted zone, note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can't create an alias resource record set in a private hosted zone to route traffic
        /// to a CloudFront distribution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about creating failover resource record sets in a private hosted zone,
        /// see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-private-hosted-zones.html">Configuring
        /// Failover in a Private Hosted Zone</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AliasTarget AliasTarget
        {
            get { return this._aliasTarget; }
            set { this._aliasTarget = value; }
        }

        // Check to see if AliasTarget property is set
        internal bool IsSetAliasTarget()
        {
            return this._aliasTarget != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheckId. 
        /// <para>
        /// If you want Amazon Route 53 to return this resource record set in response to a DNS
        /// query only when the status of a health check is healthy, include the <c>HealthCheckId</c>
        /// element and specify the ID of the applicable health check.
        /// </para>
        ///  
        /// <para>
        /// Route 53 determines whether a resource record set is healthy based on one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// By periodically sending a request to the endpoint that is specified in the health
        /// check
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// By aggregating the status of a specified group of health checks (calculated health
        /// checks)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// By determining the current state of a CloudWatch alarm (CloudWatch metric health checks)
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// Route 53 doesn't check the health of the endpoint that is specified in the resource
        /// record set, for example, the endpoint specified by the IP address in the <c>Value</c>
        /// element. When you add a <c>HealthCheckId</c> element to a resource record set, Route
        /// 53 checks the health of the endpoint that you specified in the health check. 
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see the following topics in the <i>Amazon Route 53 Developer
        /// Guide</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-determining-health-of-endpoints.html">How
        /// Amazon Route 53 Determines Whether an Endpoint Is Healthy</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover.html">Route
        /// 53 Health Checks and DNS Failover</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-private-hosted-zones.html">Configuring
        /// Failover in a Private Hosted Zone</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>When to Specify HealthCheckId</b> 
        /// </para>
        ///  
        /// <para>
        /// Specifying a value for <c>HealthCheckId</c> is useful only when Route 53 is choosing
        /// between two or more resource record sets to respond to a DNS query, and you want Route
        /// 53 to base the choice in part on the status of a health check. Configuring health
        /// checks makes sense only in the following configurations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Non-alias resource record sets</b>: You're checking the health of a group of non-alias
        /// resource record sets that have the same routing policy, name, and type (such as multiple
        /// weighted records named www.example.com with a type of A) and you specify health check
        /// IDs for all the resource record sets. 
        /// </para>
        ///  
        /// <para>
        /// If the health check status for a resource record set is healthy, Route 53 includes
        /// the record among the records that it responds to DNS queries with.
        /// </para>
        ///  
        /// <para>
        /// If the health check status for a resource record set is unhealthy, Route 53 stops
        /// responding to DNS queries using the value for that resource record set.
        /// </para>
        ///  
        /// <para>
        /// If the health check status for all resource record sets in the group is unhealthy,
        /// Route 53 considers all resource record sets in the group healthy and responds to DNS
        /// queries accordingly. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Alias resource record sets</b>: You specify the following settings:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You set <c>EvaluateTargetHealth</c> to true for an alias resource record set in a
        /// group of resource record sets that have the same routing policy, name, and type (such
        /// as multiple weighted records named www.example.com with a type of A). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You configure the alias resource record set to route traffic to a non-alias resource
        /// record set in the same hosted zone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specify a health check ID for the non-alias resource record set. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the health check status is healthy, Route 53 considers the alias resource record
        /// set to be healthy and includes the alias record among the records that it responds
        /// to DNS queries with.
        /// </para>
        ///  
        /// <para>
        /// If the health check status is unhealthy, Route 53 stops responding to DNS queries
        /// using the alias resource record set.
        /// </para>
        ///  <note> 
        /// <para>
        /// The alias resource record set can also route traffic to a <i>group</i> of non-alias
        /// resource record sets that have the same routing policy, name, and type. In that configuration,
        /// associate health checks with all of the resource record sets in the group of non-alias
        /// resource record sets.
        /// </para>
        ///  </note> </li> </ul> 
        /// <para>
        ///  <b>Geolocation Routing</b> 
        /// </para>
        ///  
        /// <para>
        /// For geolocation resource record sets, if an endpoint is unhealthy, Route 53 looks
        /// for a resource record set for the larger, associated geographic region. For example,
        /// suppose you have resource record sets for a state in the United States, for the entire
        /// United States, for North America, and a resource record set that has <c>*</c> for
        /// <c>CountryCode</c> is <c>*</c>, which applies to all locations. If the endpoint for
        /// the state resource record set is unhealthy, Route 53 checks for healthy resource record
        /// sets in the following order until it finds a resource record set for which the endpoint
        /// is healthy:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The United States
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// North America
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The default resource record set
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Specifying the Health Check Endpoint by Domain Name</b> 
        /// </para>
        ///  
        /// <para>
        /// If your health checks specify the endpoint only by domain name, we recommend that
        /// you create a separate health check for each endpoint. For example, create a health
        /// check for each <c>HTTP</c> server that is serving content for <c>www.example.com</c>.
        /// For the value of <c>FullyQualifiedDomainName</c>, specify the domain name of the server
        /// (such as <c>us-east-2-www.example.com</c>), not the name of the resource record sets
        /// (<c>www.example.com</c>).
        /// </para>
        ///  <important> 
        /// <para>
        /// Health check results will be unpredictable if you do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Create a health check that has the same value for <c>FullyQualifiedDomainName</c>
        /// as the name of a resource record set.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Associate that health check with the resource record set.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        [AWSProperty(Max=64)]
        public string HealthCheckId
        {
            get { return this._healthCheckId; }
            set { this._healthCheckId = value; }
        }

        // Check to see if HealthCheckId property is set
        internal bool IsSetHealthCheckId()
        {
            return this._healthCheckId != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyInstanceId. 
        /// <para>
        /// When you create a traffic policy instance, Amazon Route 53 automatically creates a
        /// resource record set. <c>TrafficPolicyInstanceId</c> is the ID of the traffic policy
        /// instance that Route 53 created this resource record set for.
        /// </para>
        ///  <important> 
        /// <para>
        /// To delete the resource record set that is associated with a traffic policy instance,
        /// use <c>DeleteTrafficPolicyInstance</c>. Route 53 will delete the resource record set
        /// automatically. If you delete the resource record set by using <c>ChangeResourceRecordSets</c>,
        /// Route 53 doesn't automatically delete the traffic policy instance, and you'll continue
        /// to be charged for it even though it's no longer in use. 
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string TrafficPolicyInstanceId
        {
            get { return this._trafficPolicyInstanceId; }
            set { this._trafficPolicyInstanceId = value; }
        }

        // Check to see if TrafficPolicyInstanceId property is set
        internal bool IsSetTrafficPolicyInstanceId()
        {
            return this._trafficPolicyInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property CidrRoutingConfig.
        /// </summary>
        public CidrRoutingConfig CidrRoutingConfig
        {
            get { return this._cidrRoutingConfig; }
            set { this._cidrRoutingConfig = value; }
        }

        // Check to see if CidrRoutingConfig property is set
        internal bool IsSetCidrRoutingConfig()
        {
            return this._cidrRoutingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property GeoProximityLocation. 
        /// <para>
        ///  <i> GeoproximityLocation resource record sets only:</i> A complex type that lets
        /// you control how Route 53 responds to DNS queries based on the geographic origin of
        /// the query and your resources. 
        /// </para>
        /// </summary>
        public GeoProximityLocation GeoProximityLocation
        {
            get { return this._geoProximityLocation; }
            set { this._geoProximityLocation = value; }
        }

        // Check to see if GeoProximityLocation property is set
        internal bool IsSetGeoProximityLocation()
        {
            return this._geoProximityLocation != null;
        }

    }
}