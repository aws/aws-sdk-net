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
    /// Container for the parameters to the DeleteVPCAssociationAuthorization operation.
    /// Removes authorization to submit an <code>AssociateVPCWithHostedZone</code> request
    /// to associate a specified VPC with a hosted zone that was created by a different account.
    /// You must use the account that created the hosted zone to submit a <code>DeleteVPCAssociationAuthorization</code>
    /// request.
    /// 
    ///  <important> 
    /// <para>
    /// Sending this request only prevents the AWS account that created the VPC from associating
    /// the VPC with the Amazon Route 53 hosted zone in the future. If the VPC is already
    /// associated with the hosted zone, <code>DeleteVPCAssociationAuthorization</code> won't
    /// disassociate the VPC from the hosted zone. If you want to delete an existing association,
    /// use <code>DisassociateVPCFromHostedZone</code>.
    /// </para>
    ///  </important> 
    /// <para>
    /// Send a <code>DELETE</code> request to the <code>/2013-04-01/hostedzone/<i>hosted zone
    /// ID</i>/deauthorizevpcassociation</code> resource. The request body must include a
    /// document with a <code>DeleteVPCAssociationAuthorizationRequest</code> element.
    /// </para>
    /// </summary>
    public partial class DeleteVPCAssociationAuthorizationRequest : AmazonRoute53Request
    {
        private string _hostedZoneId;
        private VPC _vpc;

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// When removing authorization to associate a VPC that was created by one AWS account
        /// with a hosted zone that was created with a different AWS account, the ID of the hosted
        /// zone.
        /// </para>
        /// </summary>
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
        /// When removing authorization to associate a VPC that was created by one AWS account
        /// with a hosted zone that was created with a different AWS account, a complex type that
        /// includes the ID and region of the VPC.
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

    }
}