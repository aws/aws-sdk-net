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
    /// Container for the parameters to the CreateVPCAssociationAuthorization operation.
    /// Authorizes the Amazon Web Services account that created a specified VPC to submit
    /// an <c>AssociateVPCWithHostedZone</c> request to associate the VPC with a specified
    /// hosted zone that was created by a different account. To submit a <c>CreateVPCAssociationAuthorization</c>
    /// request, you must use the account that created the hosted zone. After you authorize
    /// the association, use the account that created the VPC to submit an <c>AssociateVPCWithHostedZone</c>
    /// request.
    /// 
    ///  <note> 
    /// <para>
    /// If you want to associate multiple VPCs that you created by using one account with
    /// a hosted zone that you created by using a different account, you must submit one authorization
    /// request for each VPC.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateVPCAssociationAuthorizationRequest : AmazonRoute53Request
    {
        private string _hostedZoneId;
        private VPC _vpc;

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the private hosted zone that you want to authorize associating a VPC with.
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
        /// A complex type that contains the VPC ID and region for the VPC that you want to authorize
        /// associating with your hosted zone.
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

    }
}