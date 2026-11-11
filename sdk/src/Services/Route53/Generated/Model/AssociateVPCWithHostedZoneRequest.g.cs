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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the AssociateVPCWithHostedZone operation. Associates
    /// an Amazon VPC with a private hosted zone. <important> <para> To perform the association,
    /// the VPC and the private hosted zone must already exist. You can't convert a public
    /// hosted zone into a private hosted zone. </para> </important> <note> <para> If you
    /// want to associate a VPC that was created by using one Amazon Web Services account
    /// with a private hosted zone that was created by using a different account, the Amazon
    /// Web Services account that created the private hosted zone must first submit a <c>CreateVPCAssociationAuthorization</c>
    /// request. Then the account that created the VPC must submit an <c>AssociateVPCWithHostedZone</c>
    /// request. </para> </note> <note> <para> When granting access, the hosted zone and the
    /// Amazon VPC must belong to the same partition. A partition is a group of Amazon Web
    /// Services Regions. Each Amazon Web Services account is scoped to one partition. </para>
    /// <para> The following are the supported partitions: </para> <ul> <li> <para> <c>aws</c>
    /// - Amazon Web Services Regions </para> </li> <li> <para> <c>aws-cn</c> - China Regions
    /// </para> </li> <li> <para> <c>aws-us-gov</c> - Amazon Web Services GovCloud (US) Region
    /// </para> </li> </ul> <para> For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Access
    /// Management</a> in the <i>Amazon Web Services General Reference</i>. </para> </note>
    /// </summary>
    public partial class AssociateVPCWithHostedZoneRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the private hosted zone that you want to associate an Amazon VPC with.
        /// </para>
        ///  
        /// <para>
        /// Note that you can't associate a VPC with a hosted zone that doesn't have an existing
        /// VPC association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string HostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneId property is set.
        /// </summary>
        internal bool IsSetHostedZoneId() => this.HostedZoneId != null;

        /// <summary>
        /// Gets and sets the property VPC. 
        /// <para>
        /// A complex type that contains information about the VPC that you want to associate
        /// with a private hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VPC VPC { get; set; }

        /// <summary>
        /// Checks to see if the VPC property is set.
        /// </summary>
        internal bool IsSetVPC() => this.VPC != null;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        ///  <i>Optional:</i> A comment about the association request.
        /// </para>
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;
    }
}
