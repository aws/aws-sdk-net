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
    /// Container for the parameters to the DisassociateVPCFromHostedZone operation.
    /// Disassociates a VPC from a Amazon Route 53 private hosted zone. 
    /// 
    ///  <note> 
    /// <para>
    /// You can't disassociate the last VPC from a private hosted zone.
    /// </para>
    ///  </note> <important> 
    /// <para>
    /// You can't disassociate a VPC from a private hosted zone when only one VPC is associated
    /// with the hosted zone. You also can't convert a private hosted zone into a public hosted
    /// zone.
    /// </para>
    ///  </important>
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