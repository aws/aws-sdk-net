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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
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
namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateResolverEndpoint operation.
    /// Updates the name, or endpoint type for an inbound or an outbound Resolver endpoint.
    /// You can only update between IPV4 and DUALSTACK, IPV6 endpoint type can't be updated
    /// to other type.
    /// </summary>
    public partial class UpdateResolverEndpointRequest : AmazonRoute53ResolverRequest
    {
        private bool? _dns64Enabled;
        private bool? _ipv6InternetAccessEnabled;
        private string _name;
        private List<string> _protocols = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _resolverEndpointId;
        private ResolverEndpointType _resolverEndpointType;
        private bool? _rniEnhancedMetricsEnabled;
        private bool? _targetNameServerMetricsEnabled;
        private List<UpdateIpAddress> _updateIpAddresses = AWSConfigs.InitializeCollections ? new List<UpdateIpAddress>() : null;

        /// <summary>
        /// Gets and sets the property Dns64Enabled. 
        /// <para>
        /// Specifies whether DNS64 is enabled for the inbound Resolver endpoint. When set to
        /// <c>true</c>, Route 53 Resolver synthesizes AAAA (IPv6) records for IPv4-only services
        /// by prepending the <c>64:ff9b::/96</c> prefix to the IPv4 address. This enables IPv6-only
        /// clients that send queries through the inbound endpoint to reach IPv4-only services.
        /// DNS64 works with NAT64 to provide complete IPv6-to-IPv4 translation.
        /// </para>
        /// </summary>
        public bool? Dns64Enabled
        {
            get { return this._dns64Enabled; }
            set { this._dns64Enabled = value; }
        }

        // Check to see if Dns64Enabled property is set
        internal bool IsSetDns64Enabled()
        {
            return this._dns64Enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv6InternetAccessEnabled. 
        /// <para>
        /// Specifies whether IPv6 internet access is enabled for the outbound Resolver endpoint.
        /// When set to <c>true</c>, the endpoint elastic network interfaces (ENIs) can forward
        /// DNS queries to public IPv6 targets through an internet gateway.
        /// </para>
        ///  <important> 
        /// <para>
        /// When you enable IPv6 internet access, use network controls like security groups, NACLs,
        /// or egress-only internet gateways to protect the endpoint ENIs from unsolicited ingress
        /// traffic. Be aware that some network controls can affect DNS query throughput due to
        /// connection tracking. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/userguide/security-group-connection-tracking.html">Amazon
        /// EC2 security group connection tracking</a> and <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/best-practices-resolver-endpoint-scaling.html">Resolver
        /// endpoint scaling</a>.
        /// </para>
        ///  </important>
        /// </summary>
        public bool? Ipv6InternetAccessEnabled
        {
            get { return this._ipv6InternetAccessEnabled; }
            set { this._ipv6InternetAccessEnabled = value; }
        }

        // Check to see if Ipv6InternetAccessEnabled property is set
        internal bool IsSetIpv6InternetAccessEnabled()
        {
            return this._ipv6InternetAccessEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Resolver endpoint that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
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
        /// Gets and sets the property Protocols. 
        /// <para>
        ///  The protocols you want to use for the endpoint. DoH-FIPS is applicable for default
        /// inbound endpoints only. 
        /// </para>
        ///  
        /// <para>
        /// For a default inbound endpoint you can apply the protocols as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Do53 and DoH in combination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do53 and DoH-FIPS in combination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do53 alone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DoH alone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DoH-FIPS alone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// None, which is treated as Do53.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a delegation inbound endpoint you can use Do53 only.
        /// </para>
        ///  
        /// <para>
        /// For an outbound endpoint you can apply the protocols as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Do53 and DoH in combination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do53 alone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DoH alone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// None, which is treated as Do53.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        ///  You can't change the protocol of an inbound endpoint directly from only Do53 to only
        /// DoH, or DoH-FIPS. This is to prevent a sudden disruption to incoming traffic that
        /// relies on Do53. To change the protocol from Do53 to DoH, or DoH-FIPS, you must first
        /// enable both Do53 and DoH, or Do53 and DoH-FIPS, to make sure that all incoming traffic
        /// has transferred to using the DoH protocol, or DoH-FIPS, and then remove the Do53.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> Protocols
        {
            get { return this._protocols; }
            set { this._protocols = value; }
        }

        // Check to see if Protocols property is set
        internal bool IsSetProtocols()
        {
            return this._protocols != null && (this._protocols.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResolverEndpointId. 
        /// <para>
        /// The ID of the Resolver endpoint that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ResolverEndpointId
        {
            get { return this._resolverEndpointId; }
            set { this._resolverEndpointId = value; }
        }

        // Check to see if ResolverEndpointId property is set
        internal bool IsSetResolverEndpointId()
        {
            return this._resolverEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property ResolverEndpointType. 
        /// <para>
        ///  Specifies the endpoint type for what type of IP address the endpoint uses to forward
        /// DNS queries. 
        /// </para>
        ///  
        /// <para>
        /// Updating to <c>IPV6</c> type isn't currently supported.
        /// </para>
        /// </summary>
        public ResolverEndpointType ResolverEndpointType
        {
            get { return this._resolverEndpointType; }
            set { this._resolverEndpointType = value; }
        }

        // Check to see if ResolverEndpointType property is set
        internal bool IsSetResolverEndpointType()
        {
            return this._resolverEndpointType != null;
        }

        /// <summary>
        /// Gets and sets the property RniEnhancedMetricsEnabled. 
        /// <para>
        /// Updates whether RNI enhanced metrics are enabled for the Resolver endpoints. When
        /// set to true, one-minute granular metrics are published in CloudWatch for each RNI
        /// associated with this endpoint. When set to false, metrics are not published.
        /// </para>
        ///  <note> 
        /// <para>
        /// Standard CloudWatch pricing and charges are applied for using the Route 53 Resolver
        /// endpoint RNI enhanced metrics. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/monitoring-resolver-with-cloudwatch.html">Detailed
        /// metrics</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? RniEnhancedMetricsEnabled
        {
            get { return this._rniEnhancedMetricsEnabled; }
            set { this._rniEnhancedMetricsEnabled = value; }
        }

        // Check to see if RniEnhancedMetricsEnabled property is set
        internal bool IsSetRniEnhancedMetricsEnabled()
        {
            return this._rniEnhancedMetricsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetNameServerMetricsEnabled. 
        /// <para>
        /// Updates whether target name server metrics are enabled for the outbound Resolver endpoints.
        /// When set to true, one-minute granular metrics are published in CloudWatch for each
        /// target name server associated with this endpoint. When set to false, metrics are not
        /// published. This setting is not supported for inbound Resolver endpoints.
        /// </para>
        ///  <note> 
        /// <para>
        /// Standard CloudWatch pricing and charges are applied for using the Route 53 Resolver
        /// endpoint target name server metrics. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/monitoring-resolver-with-cloudwatch.html">Detailed
        /// metrics</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? TargetNameServerMetricsEnabled
        {
            get { return this._targetNameServerMetricsEnabled; }
            set { this._targetNameServerMetricsEnabled = value; }
        }

        // Check to see if TargetNameServerMetricsEnabled property is set
        internal bool IsSetTargetNameServerMetricsEnabled()
        {
            return this._targetNameServerMetricsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdateIpAddresses. 
        /// <para>
        ///  Specifies the IPv6 address when you update the Resolver endpoint from IPv4 to dual-stack.
        /// If you don't specify an IPv6 address, one will be automatically chosen from your subnet.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<UpdateIpAddress> UpdateIpAddresses
        {
            get { return this._updateIpAddresses; }
            set { this._updateIpAddresses = value; }
        }

        // Check to see if UpdateIpAddresses property is set
        internal bool IsSetUpdateIpAddresses()
        {
            return this._updateIpAddresses != null && (this._updateIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}