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
    /// Container for the parameters to the ListVPCAssociationAuthorizations operation.
    /// Gets a list of the VPCs that were created by other accounts and that can be associated
    /// with a specified hosted zone because you've submitted one or more <c>CreateVPCAssociationAuthorization</c>
    /// requests. 
    /// 
    ///  
    /// <para>
    /// The response includes a <c>VPCs</c> element with a <c>VPC</c> child element for each
    /// VPC that can be associated with the hosted zone.
    /// </para>
    /// </summary>
    public partial class ListVPCAssociationAuthorizationsRequest : AmazonRoute53Request
    {
        private string _hostedZoneId;
        private string _nextToken;
        private string _maxResults;

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the hosted zone for which you want a list of VPCs that can be associated
        /// with the hosted zone.
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
        ///  <i>Optional</i>: If a response includes a <c>NextToken</c> element, there are more
        /// VPCs that can be associated with the specified hosted zone. To get the next page of
        /// results, submit another request, and include the value of <c>NextToken</c> from the
        /// response in the <c>nexttoken</c> parameter in another <c>ListVPCAssociationAuthorizations</c>
        /// request.
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  <i>Optional</i>: An integer that specifies the maximum number of VPCs that you want
        /// Amazon Route 53 to return. If you don't specify a value for <c>MaxResults</c>, Route
        /// 53 returns up to 50 VPCs per page.
        /// </para>
        /// </summary>
        public string MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults != null;
        }

    }
}