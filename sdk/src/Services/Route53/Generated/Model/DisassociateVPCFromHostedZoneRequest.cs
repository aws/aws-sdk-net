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
    /// Container for the parameters to the DisassociateVPCFromHostedZone operation.
    /// Disassociates an Amazon Virtual Private Cloud (Amazon VPC) from an Amazon Route 53
    /// private hosted zone. Note the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// You can't disassociate the last Amazon VPC from a private hosted zone.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can't convert a private hosted zone into a public hosted zone.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can submit a <c>DisassociateVPCFromHostedZone</c> request using either the account
    /// that created the hosted zone or the account that created the Amazon VPC.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Some services, such as Cloud Map and Amazon Elastic File System (Amazon EFS) automatically
    /// create hosted zones and associate VPCs with the hosted zones. A service can create
    /// a hosted zone using your account or using its own account. You can disassociate a
    /// VPC from a hosted zone only if the service created the hosted zone using your account.
    /// </para>
    ///  
    /// <para>
    /// When you run <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_ListHostedZonesByVPC.html">DisassociateVPCFromHostedZone</a>,
    /// if the hosted zone has a value for <c>OwningAccount</c>, you can use <c>DisassociateVPCFromHostedZone</c>.
    /// If the hosted zone has a value for <c>OwningService</c>, you can't use <c>DisassociateVPCFromHostedZone</c>.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// When revoking access, the hosted zone and the Amazon VPC must belong to the same partition.
    /// A partition is a group of Amazon Web Services Regions. Each Amazon Web Services account
    /// is scoped to one partition.
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
    public partial class DisassociateVPCFromHostedZoneRequest : AmazonRoute53Request
    {
        private string _hostedZoneId;
        private VPC _vpc;
        private string _comment;

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the private hosted zone that you want to disassociate a VPC from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=32)]
        public string HostedZoneId
        {
            get { return this._hostedZoneId; }
            set { this._hostedZoneId = value; }
        }

        // Check to see if HostedZoneId property is set
        internal bool IsSetHostedZoneId()
        {
            return this._hostedZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property VPC. 
        /// <para>
        /// A complex type that contains information about the VPC that you're disassociating
        /// from the specified hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Comment. 
        /// <para>
        ///  <i>Optional:</i> A comment about the disassociation request.
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

    }
}