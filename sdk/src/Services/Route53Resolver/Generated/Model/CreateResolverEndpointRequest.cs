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
    /// Container for the parameters to the CreateResolverEndpoint operation.
    /// Creates a Resolver endpoint. There are two types of Resolver endpoints, inbound and
    /// outbound:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// An <i>inbound Resolver endpoint</i> forwards DNS queries to the DNS service for a
    /// VPC from your network.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An <i>outbound Resolver endpoint</i> forwards DNS queries from the DNS service for
    /// a VPC to your network.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateResolverEndpointRequest : AmazonRoute53ResolverRequest
    {
        private string _creatorRequestId;
        private ResolverEndpointDirection _direction;
        private List<IpAddressRequest> _ipAddresses = AWSConfigs.InitializeCollections ? new List<IpAddressRequest>() : null;
        private string _name;
        private string _outpostArn;
        private string _preferredInstanceType;
        private List<string> _protocols = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ResolverEndpointType _resolverEndpointType;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and that allows failed requests to be
        /// retried without the risk of running the operation twice. <c>CreatorRequestId</c> can
        /// be any unique string, for example, a date/time stamp. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// Specify the applicable value:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INBOUND</c>: Resolver forwards DNS queries to the DNS service for a VPC from your
        /// network.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OUTBOUND</c>: Resolver forwards DNS queries from the DNS service for a VPC to
        /// your network.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INBOUND_DELEGATION</c>: Resolver delegates queries to Route 53 private hosted
        /// zones from your network.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResolverEndpointDirection Direction
        {
            get { return this._direction; }
            set { this._direction = value; }
        }

        // Check to see if Direction property is set
        internal bool IsSetDirection()
        {
            return this._direction != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddresses. 
        /// <para>
        /// The subnets and IP addresses in your VPC that DNS queries originate from (for outbound
        /// endpoints) or that you forward DNS queries to (for inbound endpoints). The subnet
        /// ID uniquely identifies a VPC. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Even though the minimum is 1, Route 53 requires that you create at least two.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=20)]
        public List<IpAddressRequest> IpAddresses
        {
            get { return this._ipAddresses; }
            set { this._ipAddresses = value; }
        }

        // Check to see if IpAddresses property is set
        internal bool IsSetIpAddresses()
        {
            return this._ipAddresses != null && (this._ipAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name that lets you easily find a configuration in the Resolver dashboard
        /// in the Route 53 console.
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
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost. If you specify this, you must also
        /// specify a value for the <c>PreferredInstanceType</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredInstanceType. 
        /// <para>
        /// The instance type. If you specify this, you must also specify a value for the <c>OutpostArn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PreferredInstanceType
        {
            get { return this._preferredInstanceType; }
            set { this._preferredInstanceType = value; }
        }

        // Check to see if PreferredInstanceType property is set
        internal bool IsSetPreferredInstanceType()
        {
            return this._preferredInstanceType != null;
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
        ///  </li> </ul>
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
        /// Gets and sets the property ResolverEndpointType. 
        /// <para>
        ///  For the endpoint type you can choose either IPv4, IPv6, or dual-stack. A dual-stack
        /// endpoint means that it will resolve via both IPv4 and IPv6. This endpoint type is
        /// applied to all IP addresses. 
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
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The ID of one or more security groups that you want to use to control access to this
        /// VPC. The security group that you specify must include one or more inbound rules (for
        /// inbound Resolver endpoints) or outbound rules (for outbound Resolver endpoints). Inbound
        /// and outbound rules must allow TCP and UDP access. For inbound access, open port 53.
        /// For outbound access, open the port that you're using for DNS queries on your network.
        /// </para>
        ///  
        /// <para>
        /// Some security group rules will cause your connection to be tracked. For outbound resolver
        /// endpoint, it can potentially impact the maximum queries per second from outbound endpoint
        /// to your target name server. For inbound resolver endpoint, it can bring down the overall
        /// maximum queries per second per IP address to as low as 1500. To avoid connection tracking
        /// caused by security group, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/security-group-connection-tracking.html#untracked-connectionsl">Untracked
        /// connections</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of the tag keys and values that you want to associate with the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}