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
    /// Container for the parameters to the AssociateVPCWithHostedZone operation.
    /// This action associates a VPC with an hosted zone. 
    /// 
    ///  
    /// <para>
    ///  To associate a VPC with an hosted zone, send a <code>POST</code> request to the <code>2013-04-01/hostedzone/<i>hosted
    /// zone ID</i>/associatevpc</code> resource. The request body must include an XML document
    /// with a <code>AssociateVPCWithHostedZoneRequest</code> element. The response returns
    /// the <code>AssociateVPCWithHostedZoneResponse</code> element that contains <code>ChangeInfo</code>
    /// for you to track the progress of the <code>AssociateVPCWithHostedZoneRequest</code>
    /// you made. See <code>GetChange</code> operation for how to track the progress of your
    /// change.
    /// </para>
    /// </summary>
    public partial class AssociateVPCWithHostedZoneRequest : AmazonRoute53Request
    {
        private string _hostedZoneId;
        private VPC _vPC;
        private string _comment;

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        ///  The ID of the hosted zone you want to associate your VPC with.
        /// </para>
        ///  
        /// <para>
        /// Note that you cannot associate a VPC with a hosted zone that doesn't have an existing
        /// VPC association.
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
        /// The VPC that you want your hosted zone to be associated with. 
        /// </para>
        /// </summary>
        public VPC VPC
        {
            get { return this._vPC; }
            set { this._vPC = value; }
        }

        // Check to see if VPC property is set
        internal bool IsSetVPC()
        {
            return this._vPC != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// <i>Optional:</i> Any comments you want to include about a <code>AssociateVPCWithHostedZoneRequest</code>.
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