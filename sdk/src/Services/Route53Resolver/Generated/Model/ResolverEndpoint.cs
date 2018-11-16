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
    /// In the response to a <a>CreateResolverEndpoint</a>, <a>DeleteResolverEndpoint</a>,
    /// <a>GetResolverEndpoint</a>, <a>ListResolverEndpoints</a>, or <a>UpdateResolverEndpoint</a>
    /// request, a complex type that contains settings for an existing inbound or outbound
    /// resolver endpoint.
    /// </summary>
    public partial class ResolverEndpoint
    {
        private string _arn;
        private string _creationTime;
        private string _creatorRequestId;
        private ResolverEndpointDirection _direction;
        private string _hostVPCId;
        private string _id;
        private int? _ipAddressCount;
        private string _modificationTime;
        private string _name;
        private List<string> _securityGroupIds = new List<string>();
        private ResolverEndpointStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN (Amazon Resource Name) for the resolver endpoint.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the endpoint was created, in Unix time format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        public string CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime != null;
        }

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request that created the resolver endpoint. The
        /// <code>CreatorRequestId</code> allows failed requests to be retried without the risk
        /// of executing the operation twice.
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
        /// Indicates whether the resolver endpoint allows inbound or outbound DNS queries:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>INBOUND</code>: allows DNS queries to your VPC from your network or another
        /// VPC
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OUTBOUND</code>: allows DNS queries from your VPC to your network or another
        /// VPC
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
        /// Gets and sets the property HostVPCId. 
        /// <para>
        /// The ID of the VPC that you want to create the resolver endpoint in.
        /// </para>
        /// </summary>
        public string HostVPCId
        {
            get { return this._hostVPCId; }
            set { this._hostVPCId = value; }
        }

        // Check to see if HostVPCId property is set
        internal bool IsSetHostVPCId()
        {
            return this._hostVPCId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the resolver endpoint.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressCount. 
        /// <para>
        /// The number of IP addresses that the resolver endpoint can use for DNS queries.
        /// </para>
        /// </summary>
        public int IpAddressCount
        {
            get { return this._ipAddressCount.GetValueOrDefault(); }
            set { this._ipAddressCount = value; }
        }

        // Check to see if IpAddressCount property is set
        internal bool IsSetIpAddressCount()
        {
            return this._ipAddressCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModificationTime. 
        /// <para>
        /// The date and time that the endpoint was last modified, in Unix time format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        public string ModificationTime
        {
            get { return this._modificationTime; }
            set { this._modificationTime = value; }
        }

        // Check to see if ModificationTime property is set
        internal bool IsSetModificationTime()
        {
            return this._modificationTime != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name that you assigned to the resolver endpoint when you submitted a <a>CreateResolverEndpoint</a>
        /// request.
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
        /// The ID of one or more security groups that control access to this VPC. The security
        /// group must include one or more inbound resolver rules.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// A code that specifies the current status of the resolver endpoint.
        /// </para>
        /// </summary>
        public ResolverEndpointStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A detailed description of the status of the resolver endpoint.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}