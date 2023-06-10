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
 * Do not modify this file. This file is generated from the s3outposts-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Outposts.Model
{
    /// <summary>
    /// Amazon S3 on Outposts Access Points simplify managing data access at scale for shared
    /// datasets in S3 on Outposts. S3 on Outposts uses endpoints to connect to Outposts buckets
    /// so that you can perform actions within your virtual private cloud (VPC). For more
    /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/WorkingWithS3Outposts.html">
    /// Accessing S3 on Outposts using VPC-only access points</a> in the <i>Amazon Simple
    /// Storage Service User Guide</i>.
    /// </summary>
    public partial class Endpoint
    {
        private EndpointAccessType _accessType;
        private string _cidrBlock;
        private DateTime? _creationTime;
        private string _customerOwnedIpv4Pool;
        private string _endpointArn;
        private FailedReason _failedReason;
        private List<NetworkInterface> _networkInterfaces = new List<NetworkInterface>();
        private string _outpostsId;
        private string _securityGroupId;
        private EndpointStatus _status;
        private string _subnetId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AccessType. 
        /// <para>
        /// The type of connectivity used to access the Amazon S3 on Outposts endpoint.
        /// </para>
        /// </summary>
        public EndpointAccessType AccessType
        {
            get { return this._accessType; }
            set { this._accessType = value; }
        }

        // Check to see if AccessType property is set
        internal bool IsSetAccessType()
        {
            return this._accessType != null;
        }

        /// <summary>
        /// Gets and sets the property CidrBlock. 
        /// <para>
        /// The VPC CIDR committed by this endpoint.
        /// </para>
        /// </summary>
        public string CidrBlock
        {
            get { return this._cidrBlock; }
            set { this._cidrBlock = value; }
        }

        // Check to see if CidrBlock property is set
        internal bool IsSetCidrBlock()
        {
            return this._cidrBlock != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the endpoint was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomerOwnedIpv4Pool. 
        /// <para>
        /// The ID of the customer-owned IPv4 address pool used for the endpoint.
        /// </para>
        /// </summary>
        public string CustomerOwnedIpv4Pool
        {
            get { return this._customerOwnedIpv4Pool; }
            set { this._customerOwnedIpv4Pool = value; }
        }

        // Check to see if CustomerOwnedIpv4Pool property is set
        internal bool IsSetCustomerOwnedIpv4Pool()
        {
            return this._customerOwnedIpv4Pool != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint.
        /// </para>
        /// </summary>
        public string EndpointArn
        {
            get { return this._endpointArn; }
            set { this._endpointArn = value; }
        }

        // Check to see if EndpointArn property is set
        internal bool IsSetEndpointArn()
        {
            return this._endpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property FailedReason. 
        /// <para>
        /// The failure reason, if any, for a create or delete endpoint operation.
        /// </para>
        /// </summary>
        public FailedReason FailedReason
        {
            get { return this._failedReason; }
            set { this._failedReason = value; }
        }

        // Check to see if FailedReason property is set
        internal bool IsSetFailedReason()
        {
            return this._failedReason != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// The network interface of the endpoint.
        /// </para>
        /// </summary>
        public List<NetworkInterface> NetworkInterfaces
        {
            get { return this._networkInterfaces; }
            set { this._networkInterfaces = value; }
        }

        // Check to see if NetworkInterfaces property is set
        internal bool IsSetNetworkInterfaces()
        {
            return this._networkInterfaces != null && this._networkInterfaces.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OutpostsId. 
        /// <para>
        /// The ID of the Outposts.
        /// </para>
        /// </summary>
        public string OutpostsId
        {
            get { return this._outpostsId; }
            set { this._outpostsId = value; }
        }

        // Check to see if OutpostsId property is set
        internal bool IsSetOutpostsId()
        {
            return this._outpostsId != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupId. 
        /// <para>
        /// The ID of the security group used for the endpoint.
        /// </para>
        /// </summary>
        public string SecurityGroupId
        {
            get { return this._securityGroupId; }
            set { this._securityGroupId = value; }
        }

        // Check to see if SecurityGroupId property is set
        internal bool IsSetSecurityGroupId()
        {
            return this._securityGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the endpoint.
        /// </para>
        /// </summary>
        public EndpointStatus Status
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
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet used for the endpoint.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC used for the endpoint.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}