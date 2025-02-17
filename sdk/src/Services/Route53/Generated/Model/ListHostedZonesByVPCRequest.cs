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
    /// Container for the parameters to the ListHostedZonesByVPC operation.
    /// Lists all the private hosted zones that a specified VPC is associated with, regardless
    /// of which Amazon Web Services account or Amazon Web Services service owns the hosted
    /// zones. The <c>HostedZoneOwner</c> structure in the response contains one of the following
    /// values:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// An <c>OwningAccount</c> element, which contains the account number of either the current
    /// Amazon Web Services account or another Amazon Web Services account. Some services,
    /// such as Cloud Map, create hosted zones using the current account. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An <c>OwningService</c> element, which identifies the Amazon Web Services service
    /// that created and owns the hosted zone. For example, if a hosted zone was created by
    /// Amazon Elastic File System (Amazon EFS), the value of <c>Owner</c> is <c>efs.amazonaws.com</c>.
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <c>ListHostedZonesByVPC</c> returns the hosted zones associated with the specified
    /// VPC and does not reflect the hosted zone associations to VPCs via Route 53 Profiles.
    /// To get the associations to a Profile, call the <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53profiles_ListProfileResourceAssociations.html">ListProfileResourceAssociations</a>
    /// API.
    /// </para>
    ///  <note> 
    /// <para>
    /// When listing private hosted zones, the hosted zone and the Amazon VPC must belong
    /// to the same partition where the hosted zones were created. A partition is a group
    /// of Amazon Web Services Regions. Each Amazon Web Services account is scoped to one
    /// partition.
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
    public partial class ListHostedZonesByVPCRequest : AmazonRoute53Request
    {
        private string _vpcId;
        private VPCRegion _vpcRegion;
        private string _maxItems;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property VPCId. 
        /// <para>
        /// The ID of the Amazon VPC that you want to list hosted zones for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string VPCId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VPCId property is set
        internal bool IsSetVPCId()
        {
            return this._vpcId != null;
        }

        /// <summary>
        /// Gets and sets the property VPCRegion. 
        /// <para>
        /// For the Amazon VPC that you specified for <c>VPCId</c>, the Amazon Web Services Region
        /// that you created the VPC in. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public VPCRegion VPCRegion
        {
            get { return this._vpcRegion; }
            set { this._vpcRegion = value; }
        }

        // Check to see if VPCRegion property is set
        internal bool IsSetVPCRegion()
        {
            return this._vpcRegion != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// (Optional) The maximum number of hosted zones that you want Amazon Route 53 to return.
        /// If the specified VPC is associated with more than <c>MaxItems</c> hosted zones, the
        /// response includes a <c>NextToken</c> element. <c>NextToken</c> contains an encrypted
        /// token that identifies the first hosted zone that Route 53 will return if you submit
        /// another request.
        /// </para>
        /// </summary>
        public string MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous response included a <c>NextToken</c> element, the specified VPC is
        /// associated with more hosted zones. To get more hosted zones, submit another <c>ListHostedZonesByVPC</c>
        /// request. 
        /// </para>
        ///  
        /// <para>
        /// For the value of <c>NextToken</c>, specify the value of <c>NextToken</c> from the
        /// previous response.
        /// </para>
        ///  
        /// <para>
        /// If the previous response didn't include a <c>NextToken</c> element, there are no more
        /// hosted zones to get.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}