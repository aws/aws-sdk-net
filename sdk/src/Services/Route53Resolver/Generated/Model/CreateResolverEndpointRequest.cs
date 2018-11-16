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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the CreateResolverEndpoint operation.
    /// Creates a resolver endpoint. There are two types of resolver endpoints, inbound and
    /// outbound:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// An <i>inbound resolver endpoint</i> forwards DNS queries to the DNS service for a
    /// VPC from your network or another VPC.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An <i>outbound resolver endpoint</i> forwards DNS queries from the DNS service for
    /// a VPC to your network or another VPC.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateResolverEndpointRequest : AmazonRoute53ResolverRequest
    {
        private string _creatorRequestId;
        private ResolverEndpointDirection _direction;
        private List<IpAddressRequest> _ipAddresses = new List<IpAddressRequest>();
        private string _name;
        private List<string> _securityGroupIds = new List<string>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and that allows failed requests to be
        /// retried without the risk of executing the operation twice. <code>CreatorRequestId</code>
        /// can be any unique string, for example, a date/time stamp. 
        /// </para>
        /// </summary>
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
        ///  <code>INBOUND</code>: Resolver forwards DNS queries to the DNS service for a VPC
        /// from your network or another VPC
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OUTBOUND</code>: Resolver forwards DNS queries from the DNS service for a VPC
        /// to your network or another VPC
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// The subnets and IP addresses in your VPC that you want DNS queries to pass through
        /// on the way from your VPCs to your network (for outbound endpoints) or on the way from
        /// your network to your VPCs (for inbound resolver endpoints). 
        /// </para>
        /// </summary>
        public List<IpAddressRequest> IpAddresses
        {
            get { return this._ipAddresses; }
            set { this._ipAddresses = value; }
        }

        // Check to see if IpAddresses property is set
        internal bool IsSetIpAddresses()
        {
            return this._ipAddresses != null && this._ipAddresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name that lets you easily find a configuration in the Resolver dashboard
        /// in the Route 53 console.
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
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The ID of one or more security groups that you want to use to control access to this
        /// VPC. The security group that you specify must include one or more inbound rules (for
        /// inbound resolver endpoints) or outbound rules (for outbound resolver endpoints).
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of the tag keys and values that you want to associate with the endpoint.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}