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
    /// A complex type that contains information about the current resource record set.
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
        private long? _ttl;
        private List<ResourceRecord> _resourceRecords = new List<ResourceRecord>();
        private AliasTarget _aliasTarget;
        private string _healthCheckId;
        private string _trafficPolicyInstanceId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ResourceRecordSet() { }

        /// <summary>
        /// Instantiates ResourceRecordSet with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the domain you want to perform the action on. Enter a fully qualified domain name, for example, <code>www.example.com</code>. You can optionally include a trailing dot. If you omit the trailing dot, Amazon Route 53 still assumes that the domain name that you specify is fully qualified. This means that Amazon Route 53 treats <code>www.example.com</code> (without a trailing dot) and <code>www.example.com.</code> (with a trailing dot) as identical. For information about how to specify characters other than a-z, 0-9, and - (hyphen) and how to specify internationalized domain names, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DomainNameFormat.html">DNS Domain Name Format</a> in the <i>Amazon Route 53 Developer Guide</i>. You can use an asterisk (*) character in the name. DNS treats the * character either as a wildcard or as the * character (ASCII 42), depending on where it appears in the name. For more information, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DomainNameFormat.html#domain-name-format-asterisk">Using an Asterisk (*) in the Names of Hosted Zones and Resource Record Sets</a> in the <i>Amazon Route 53 Developer Guide</i> <important>You can't use the * wildcard for resource records sets that have a type of NS.</important></param>
        /// <param name="type">The DNS record type. For information about different record types and how data is encoded for them, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/ResourceRecordTypes.html">Supported DNS Resource Record Types</a> in the <i>Amazon Route 53 Developer Guide</i>. Valid values for basic resource record sets: <code>A</code> | <code>AAAA</code> | <code>CNAME</code> | <code>MX</code> | <code>NS</code> | <code>PTR</code> | <code>SOA</code> | <code>SPF</code> | <code>SRV</code> | <code>TXT</code> Values for weighted, latency, geolocation, and failover resource record sets: <code>A</code> | <code>AAAA</code> | <code>CNAME</code> | <code>MX</code> | <code>PTR</code> | <code>SPF</code> | <code>SRV</code> | <code>TXT</code>. When creating a group of weighted, latency, geolocation, or failover resource record sets, specify the same value for all of the resource record sets in the group. <note>SPF records were formerly used to verify the identity of the sender of email messages. However, we no longer recommend that you create resource record sets for which the value of <code>Type</code> is <code>SPF</code>. RFC 7208, <i>Sender Policy Framework (SPF) for Authorizing Use of Domains in Email, Version 1</i>, has been updated to say, "...[I]ts existence and mechanism defined in [RFC4408] have led to some interoperability issues. Accordingly, its use is no longer appropriate for SPF version 1; implementations are not to use it." In RFC 7208, see section 14.1, <a href="http://tools.ietf.org/html/rfc7208#section-14.1">The SPF DNS Record Type</a>.</note> Values for alias resource record sets: <ul> <li><b>CloudFront distributions:</b> <code>A</code></li> <li><b>ELB load balancers:</b> <code>A</code> | <code>AAAA</code></li> <li><b>Amazon S3 buckets:</b> A</li> <li><b>Another resource record set in this hosted zone:</b> Specify the type of the resource record set for which you're creating the alias. Specify any value except <code>NS</code> or <code>SOA</code>.</li> </ul></param>
        public ResourceRecordSet(string name, RRType type)
        {
            _name = name;
            _type = type;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the domain you want to perform the action on.
        /// </para>
        ///  
        /// <para>
        /// Enter a fully qualified domain name, for example, <code>www.example.com</code>. You
        /// can optionally include a trailing dot. If you omit the trailing dot, Amazon Route
        /// 53 still assumes that the domain name that you specify is fully qualified. This means
        /// that Amazon Route 53 treats <code>www.example.com</code> (without a trailing dot)
        /// and <code>www.example.com.</code> (with a trailing dot) as identical.
        /// </para>
        ///  
        /// <para>
        /// For information about how to specify characters other than a-z, 0-9, and - (hyphen)
        /// and how to specify internationalized domain names, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DomainNameFormat.html">DNS
        /// Domain Name Format</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can use an asterisk (*) character in the name. DNS treats the * character either
        /// as a wildcard or as the * character (ASCII 42), depending on where it appears in the
        /// name. For more information, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DomainNameFormat.html#domain-name-format-asterisk">Using
        /// an Asterisk (*) in the Names of Hosted Zones and Resource Record Sets</a> in the <i>Amazon
        /// Route 53 Developer Guide</i>
        /// </para>
        ///  <important>You can't use the * wildcard for resource records sets that have a type
        /// of NS.</important>
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The DNS record type. For information about different record types and how data is
        /// encoded for them, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/ResourceRecordTypes.html">Supported
        /// DNS Resource Record Types</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid values for basic resource record sets: <code>A</code> | <code>AAAA</code> |
        /// <code>CNAME</code> | <code>MX</code> | <code>NS</code> | <code>PTR</code> | <code>SOA</code>
        /// | <code>SPF</code> | <code>SRV</code> | <code>TXT</code>
        /// </para>
        ///  
        /// <para>
        /// Values for weighted, latency, geolocation, and failover resource record sets: <code>A</code>
        /// | <code>AAAA</code> | <code>CNAME</code> | <code>MX</code> | <code>PTR</code> | <code>SPF</code>
        /// | <code>SRV</code> | <code>TXT</code>. When creating a group of weighted, latency,
        /// geolocation, or failover resource record sets, specify the same value for all of the
        /// resource record sets in the group.
        /// </para>
        ///  <note>SPF records were formerly used to verify the identity of the sender of email
        /// messages. However, we no longer recommend that you create resource record sets for
        /// which the value of <code>Type</code> is <code>SPF</code>. RFC 7208, <i>Sender Policy
        /// Framework (SPF) for Authorizing Use of Domains in Email, Version 1</i>, has been updated
        /// to say, "...[I]ts existence and mechanism defined in [RFC4408] have led to some interoperability
        /// issues. Accordingly, its use is no longer appropriate for SPF version 1; implementations
        /// are not to use it." In RFC 7208, see section 14.1, <a href="http://tools.ietf.org/html/rfc7208#section-14.1">The
        /// SPF DNS Record Type</a>.</note> 
        /// <para>
        /// Values for alias resource record sets:
        /// </para>
        ///  <ul> <li><b>CloudFront distributions:</b> <code>A</code></li> <li><b>ELB load balancers:</b>
        /// <code>A</code> | <code>AAAA</code></li> <li><b>Amazon S3 buckets:</b> A</li> <li><b>Another
        /// resource record set in this hosted zone:</b> Specify the type of the resource record
        /// set for which you're creating the alias. Specify any value except <code>NS</code>
        /// or <code>SOA</code>.</li> </ul>
        /// </summary>
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
        /// <i>Weighted, Latency, Geo, and Failover resource record sets only:</i> An identifier
        /// that differentiates among multiple resource record sets that have the same combination
        /// of DNS name and type. The value of <code>SetIdentifier</code> must be unique for each
        /// resource record set that has the same combination of DNS name and type.
        /// </para>
        /// </summary>
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
        /// <i>Weighted resource record sets only:</i> Among resource record sets that have the
        /// same combination of DNS name and type, a value that determines the proportion of DNS
        /// queries that Amazon Route 53 responds to using the current resource record set. Amazon
        /// Route 53 calculates the sum of the weights for the resource record sets that have
        /// the same combination of DNS name and type. Amazon Route 53 then responds to queries
        /// based on the ratio of a resource's weight to the total. Note the following:
        /// </para>
        ///  <ul> <li>You must specify a value for the <code>Weight</code> element for every weighted
        /// resource record set.</li> <li>You can only specify one <code>ResourceRecord</code>
        /// per weighted resource record set.</li> <li>You cannot create latency, failover, or
        /// geolocation resource record sets that have the same values for the <code>Name</code>
        /// and <code>Type</code> elements as weighted resource record sets.</li> <li>You can
        /// create a maximum of 100 weighted resource record sets that have the same values for
        /// the <code>Name</code> and <code>Type</code> elements.</li> <li>
        /// <para>
        /// For weighted (but not weighted alias) resource record sets, if you set <code>Weight</code>
        /// to <code>0</code> for a resource record set, Amazon Route 53 never responds to queries
        /// with the applicable value for that resource record set. However, if you set <code>Weight</code>
        /// to <code>0</code> for all resource record sets that have the same combination of DNS
        /// name and type, traffic is routed to all resources with equal probability.
        /// </para>
        ///  
        /// <para>
        /// The effect of setting <code>Weight</code> to <code>0</code> is different when you
        /// associate health checks with weighted resource record sets. For more information,
        /// see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-configuring-options.html">Options
        /// for Configuring Amazon Route 53 Active-Active and Active-Passive Failover</a> in the
        /// <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public long Weight
        {
            get { return this._weight.GetValueOrDefault(); }
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
        /// <i>Latency-based resource record sets only:</i> The Amazon EC2 region where the resource
        /// that is specified in this resource record set resides. The resource typically is an
        /// AWS resource, such as an Amazon EC2 instance or an ELB load balancer, and is referred
        /// to by an IP address or a DNS domain name, depending on the record type.
        /// </para>
        ///  <note>You can create latency and latency alias resource record sets only in public
        /// hosted zones.</note> 
        /// <para>
        /// When Amazon Route 53 receives a DNS query for a domain name and type for which you
        /// have created latency resource record sets, Amazon Route 53 selects the latency resource
        /// record set that has the lowest latency between the end user and the associated Amazon
        /// EC2 region. Amazon Route 53 then returns the value that is associated with the selected
        /// resource record set.
        /// </para>
        ///  
        /// <para>
        /// Note the following:
        /// </para>
        ///  <ul> <li>You can only specify one <code>ResourceRecord</code> per latency resource
        /// record set.</li> <li>You can only create one latency resource record set for each
        /// Amazon EC2 region.</li> <li>You are not required to create latency resource record
        /// sets for all Amazon EC2 regions. Amazon Route 53 will choose the region with the best
        /// latency from among the regions for which you create latency resource record sets.</li>
        /// <li>You cannot create non-latency resource record sets that have the same values for
        /// the <code>Name</code> and <code>Type</code> elements as latency resource record sets.</li>
        /// </ul>
        /// </summary>
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
        /// <i>Geo location resource record sets only:</i> A complex type that lets you control
        /// how Amazon Route 53 responds to DNS queries based on the geographic origin of the
        /// query. For example, if you want all queries from Africa to be routed to a web server
        /// with an IP address of <code>192.0.2.111</code>, create a resource record set with
        /// a <code>Type</code> of <code>A</code> and a <code>ContinentCode</code> of <code>AF</code>.
        /// </para>
        ///  <note>You can create geolocation and geolocation alias resource record sets only
        /// in public hosted zones.</note> 
        /// <para>
        /// If you create separate resource record sets for overlapping geographic regions (for
        /// example, one resource record set for a continent and one for a country on the same
        /// continent), priority goes to the smallest geographic region. This allows you to route
        /// most queries for a continent to one resource and to route queries for a country on
        /// that continent to a different resource.
        /// </para>
        ///  
        /// <para>
        /// You cannot create two geolocation resource record sets that specify the same geographic
        /// location.
        /// </para>
        ///  
        /// <para>
        /// The value <code>*</code> in the <code>CountryCode</code> element matches all geographic
        /// locations that aren't specified in other geolocation resource record sets that have
        /// the same values for the <code>Name</code> and <code>Type</code> elements.
        /// </para>
        ///  <important>Geolocation works by mapping IP addresses to locations. However, some
        /// IP addresses aren't mapped to geographic locations, so even if you create geolocation
        /// resource record sets that cover all seven continents, Amazon Route 53 will receive
        /// some DNS queries from locations that it can't identify. We recommend that you create
        /// a resource record set for which the value of <code>CountryCode</code> is <code>*</code>,
        /// which handles both queries that come from locations for which you haven't created
        /// geolocation resource record sets and queries from IP addresses that aren't mapped
        /// to a location. If you don't create a <code>*</code> resource record set, Amazon Route
        /// 53 returns a "no answer" response for queries from those locations.</important> 
        /// <para>
        /// You cannot create non-geolocation resource record sets that have the same values for
        /// the <code>Name</code> and <code>Type</code> elements as geolocation resource record
        /// sets.
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
        /// <i>Failover resource record sets only:</i> To configure failover, you add the <code>Failover</code>
        /// element to two resource record sets. For one resource record set, you specify <code>PRIMARY</code>
        /// as the value for <code>Failover</code>; for the other resource record set, you specify
        /// <code>SECONDARY</code>. In addition, you include the <code>HealthCheckId</code> element
        /// and specify the health check that you want Amazon Route 53 to perform for each resource
        /// record set.
        /// </para>
        ///  <note>You can create failover and failover alias resource record sets only in public
        /// hosted zones.</note> 
        /// <para>
        /// Except where noted, the following failover behaviors assume that you have included
        /// the <code>HealthCheckId</code> element in both resource record sets:
        /// </para>
        ///  <ul> <li>When the primary resource record set is healthy, Amazon Route 53 responds
        /// to DNS queries with the applicable value from the primary resource record set regardless
        /// of the health of the secondary resource record set.</li> <li>When the primary resource
        /// record set is unhealthy and the secondary resource record set is healthy, Amazon Route
        /// 53 responds to DNS queries with the applicable value from the secondary resource record
        /// set.</li> <li>When the secondary resource record set is unhealthy, Amazon Route 53
        /// responds to DNS queries with the applicable value from the primary resource record
        /// set regardless of the health of the primary resource record set.</li> <li>If you omit
        /// the <code>HealthCheckId</code> element for the secondary resource record set, and
        /// if the primary resource record set is unhealthy, Amazon Route 53 always responds to
        /// DNS queries with the applicable value from the secondary resource record set. This
        /// is true regardless of the health of the associated endpoint.</li> </ul> 
        /// <para>
        /// You cannot create non-failover resource record sets that have the same values for
        /// the <code>Name</code> and <code>Type</code> elements as failover resource record sets.
        /// </para>
        ///  
        /// <para>
        /// For failover alias resource record sets, you must also include the <code>EvaluateTargetHealth</code>
        /// element and set the value to true.
        /// </para>
        ///  
        /// <para>
        /// For more information about configuring failover for Amazon Route 53, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover.html">Amazon
        /// Route 53 Health Checks and DNS Failover</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>PRIMARY</code> | <code>SECONDARY</code>
        /// </para>
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
        /// Gets and sets the property TTL. 
        /// <para>
        /// The cache time to live for the current resource record set. Note the following:
        /// </para>
        ///  <ul> <li>If you're creating an alias resource record set, omit <code>TTL</code>.
        /// Amazon Route 53 uses the value of <code>TTL</code> for the alias target. </li> <li>If
        /// you're associating this resource record set with a health check (if you're adding
        /// a <code>HealthCheckId</code> element), we recommend that you specify a <code>TTL</code>
        /// of 60 seconds or less so clients respond quickly to changes in health status.</li>
        /// <li>All of the resource record sets in a group of weighted, latency, geolocation,
        /// or failover resource record sets must have the same value for <code>TTL</code>.</li>
        /// <li>If a group of weighted resource record sets includes one or more weighted alias
        /// resource record sets for which the alias target is an ELB load balancer, we recommend
        /// that you specify a <code>TTL</code> of 60 seconds for all of the non-alias weighted
        /// resource record sets that have the same name and type. Values other than 60 seconds
        /// (the TTL for load balancers) will change the effect of the values that you specify
        /// for <code>Weight</code>.</li> </ul>
        /// </summary>
        public long TTL
        {
            get { return this._ttl.GetValueOrDefault(); }
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
        /// A complex type that contains the resource records for the current resource record
        /// set.
        /// </para>
        /// </summary>
        public List<ResourceRecord> ResourceRecords
        {
            get { return this._resourceRecords; }
            set { this._resourceRecords = value; }
        }

        // Check to see if ResourceRecords property is set
        internal bool IsSetResourceRecords()
        {
            return this._resourceRecords != null && this._resourceRecords.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AliasTarget. 
        /// <para>
        /// <i>Alias resource record sets only:</i> Information about the AWS resource to which
        /// you are redirecting traffic.
        /// </para>
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
        /// <i>Health Check resource record sets only, not required for alias resource record
        /// sets:</i> An identifier that is used to identify health check associated with the
        /// resource record set.
        /// </para>
        /// </summary>
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
        /// </summary>
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

    }
}