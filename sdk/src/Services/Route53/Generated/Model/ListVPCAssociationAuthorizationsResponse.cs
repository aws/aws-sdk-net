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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains the response information for the request.
    /// </summary>
    public partial class ListVPCAssociationAuthorizationsResponse : AmazonWebServiceResponse
    {
        private string _hostedZoneId;
        private string _nextToken;
        private List<VPC> _vpCs = new List<VPC>();

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the hosted zone that you can associate the listed VPCs with.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When the response includes a <code>NextToken</code> element, there are more VPCs that
        /// can be associated with the specified hosted zone. To get the next page of VPCs, submit
        /// another <code>ListVPCAssociationAuthorizations</code> request, and include the value
        /// of the <code>NextToken</code> element from the response in the <code>nexttoken</code>
        /// request parameter.
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

        /// <summary>
        /// Gets and sets the property VPCs. 
        /// <para>
        /// The list of VPCs that are authorized to be associated with the specified hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<VPC> VPCs
        {
            get { return this._vpCs; }
            set { this._vpCs = value; }
        }

        // Check to see if VPCs property is set
        internal bool IsSetVPCs()
        {
            return this._vpCs != null && this._vpCs.Count > 0; 
        }

    }
}