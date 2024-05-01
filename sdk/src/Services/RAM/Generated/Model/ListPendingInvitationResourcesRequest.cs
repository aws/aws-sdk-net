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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
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
namespace Amazon.RAM.Model
{
    /// <summary>
    /// Container for the parameters to the ListPendingInvitationResources operation.
    /// Lists the resources in a resource share that is shared with you but for which the
    /// invitation is still <c>PENDING</c>. That means that you haven't accepted or rejected
    /// the invitation and the invitation hasn't expired.
    /// </summary>
    public partial class ListPendingInvitationResourcesRequest : AmazonRAMRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private ResourceRegionScopeFilter _resourceRegionScope;
        private string _resourceShareInvitationArn;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the total number of results that you want included on each page of the response.
        /// If you do not include this parameter, it defaults to a value that is specific to the
        /// operation. If additional items exist beyond the number you specify, the <c>NextToken</c>
        /// response element is returned with a value (not null). Include the specified value
        /// as the <c>NextToken</c> request parameter in the next call to the operation to get
        /// the next part of the results. Note that the service might return fewer results than
        /// the maximum even when there are more results available. You should check <c>NextToken</c>
        /// after every operation to ensure that you receive all of the results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specifies that you want to receive the next page of results. Valid only if you received
        /// a <c>NextToken</c> response in the previous request. If you did, it indicates that
        /// more output is available. Set this parameter to the value provided by the previous
        /// call's <c>NextToken</c> response to request the next page of results.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ResourceRegionScope. 
        /// <para>
        /// Specifies that you want the results to include only resources that have the specified
        /// scope.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL</c> – the results include both global and regional resources or resource types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GLOBAL</c> – the results include only global resources or resource types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REGIONAL</c> – the results include only regional resources or resource types.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default value is <c>ALL</c>.
        /// </para>
        /// </summary>
        public ResourceRegionScopeFilter ResourceRegionScope
        {
            get { return this._resourceRegionScope; }
            set { this._resourceRegionScope = value; }
        }

        // Check to see if ResourceRegionScope property is set
        internal bool IsSetResourceRegionScope()
        {
            return this._resourceRegionScope != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceShareInvitationArn. 
        /// <para>
        /// Specifies the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the invitation. You can use <a>GetResourceShareInvitations</a>
        /// to find the ARN of the invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceShareInvitationArn
        {
            get { return this._resourceShareInvitationArn; }
            set { this._resourceShareInvitationArn = value; }
        }

        // Check to see if ResourceShareInvitationArn property is set
        internal bool IsSetResourceShareInvitationArn()
        {
            return this._resourceShareInvitationArn != null;
        }

    }
}